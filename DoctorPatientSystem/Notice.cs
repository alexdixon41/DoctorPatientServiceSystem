using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DoctorPatientSystem
{
    class Notice
    {
        private string type;
        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }
        private string message;
        public string Message
        {
            get
            {
                return message;
            }

            set
            {
                message = value;
            }
        }
        private string sentDate;
        public string SentDate
        {
            get
            {
                return sentDate;
            }

            set
            {
                sentDate = value;
            }
        }
        private string sender;
        public string Sender
        {
            get
            {
                return sender;
            }

            set
            {
                sender = value;
            }
        }
        private string receiver;
        public string Receiver
        {
            get
            {
                return receiver;
            }

            set
            {
                receiver = value;
            }
        }
        private string status;
        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }
        private int id;
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public const int SEND_PICKUP_NOTICE_TYPE = 0;                   //notify patient when prescription is ready for pickup
        public const int SEND_CASE_DISCUSSION_NOTICE_TYPE = 1;          //notify doctor to discuss a case
        public const int SEND_REFILL_REQUEST_ACCEPT_NOTICE_TYPE = 2;    //notify patient when refill request accepted
        public const int SEND_REFILL_REQUEST_REJECT_NOTICE_TYPE = 3;    //notify patient when refill request denied
        public const int SEND_PHONECALL_REQUEST_NOTICE_TYPE = 4;                    //notify doctor to call a patient

        public static int Unread
        {
            get
            {
                return unread;
            }

            set
            {
                unread = value;
            }
        }
        private static int unread;
        private static ArrayList notices = new ArrayList();

        public static ArrayList displayNotices()
        {
            return notices;
        }

        public static void retrieveNotices()
        {
            ArrayList noticeList = new ArrayList();
            DataTable table = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "";
                if (User.Type == User.PATIENT_USER_TYPE)
                {
                    sql = "SELECT n.noticeID, n.noticeType, n.noticeStatus, " +
                            "DATE_FORMAT(n.sentDate, \"%m-%d-%Y\") AS 'sentDate', n.message, doc.name AS docName, " +
                            "pa.name AS paName, ph.name AS phName " +
                            "FROM DixonNotice n LEFT OUTER JOIN DixonDoctor doc ON n.doctorSender = doc.id " +
                            "LEFT OUTER JOIN DixonPatient pa ON n.patientSender = pa.patientID " +
                            "LEFT OUTER JOIN DixonPharmacy ph ON n.pharmacySender = ph.id " +
                            "WHERE patientReceiver = @id " +
                            "ORDER BY n.noticeStatus ASC";
                }
                else
                {
                    sql = "SELECT n.noticeID, n.noticeType, n.noticeStatus, " +
                            "DATE_FORMAT(n.sentDate, \"%m-%d-%Y\") AS 'sentDate', n.message, doc.name AS docName, " +
                            "pa.name AS paName, ph.name AS phName " +
                            "FROM DixonNotice n LEFT OUTER JOIN DixonDoctor doc ON n.doctorSender = doc.id " +
                            "LEFT OUTER JOIN DixonPatient pa ON n.patientSender = pa.patientID " +
                            "LEFT OUTER JOIN DixonPharmacy ph ON n.pharmacySender = ph.id " +
                            "WHERE doctorReceiver = @id " +
                            "ORDER BY n.noticeStatus ASC";
                }

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", User.Id);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(table);
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            int unreadCount = 0;
            foreach (DataRow row in table.Rows)
            {
                Notice newNotice = new Notice();
                newNotice.Id = (int)row["noticeId"];
                newNotice.Type = row["noticeType"].ToString();
                newNotice.Status = row["noticeStatus"].ToString();
                newNotice.SentDate = row["sentDate"].ToString();
                newNotice.Message = row["message"].ToString();
                if (!(row["docName"].ToString().Equals("")))
                    newNotice.Sender = row["docName"].ToString();
                else if (!(row["paName"].ToString().Equals("")))
                    newNotice.Sender = row["paName"].ToString();
                else if (!(row["phName"].ToString().Equals("")))
                    newNotice.Sender = row["phName"].ToString();
                if (newNotice.Status.Equals("New"))
                    unreadCount++;
                noticeList.Add(newNotice);
            }
            notices = noticeList;
            Notice.Unread = unreadCount;
        }

        public void updateStatus()
        {
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "UPDATE DixonNotice SET noticeStatus = 'Received' WHERE noticeID = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

        /// <summary>
        /// Add a notice of the specified type to the database with the specified recipient and message content
        /// </summary>
        /// <param name="receiverID">The recipient of the notice</param>
        /// <param name="message">The message content of the notice</param>
        /// <param name="noticeType">The type of notice</param>
        public static void sendNotice(int receiverID, string message, int noticeType)
        {
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql;
                MySqlCommand cmd;
                switch (noticeType)
                {
                    case SEND_CASE_DISCUSSION_NOTICE_TYPE:
                        sql = @"INSERT INTO DixonNotice (noticeType, noticeStatus, sentDate, message, pharmacySender, doctorReceiver)
                        VALUES ('Case Discussion', 'New', CURRENT_DATE, @message, @pharmID, @docID);";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@message", message);
                        cmd.Parameters.AddWithValue("@pharmID", User.Id);
                        cmd.Parameters.AddWithValue("@docID", receiverID);
                        break;
                    case SEND_PICKUP_NOTICE_TYPE:
                        sql = @"INSERT INTO DixonNotice (noticeType, noticeStatus, sentDate, message, pharmacySender, patientReceiver)
                        VALUES ('Pickup', 'New', CURRENT_DATE, @message, @pharmID, @patientID);";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@message", message);
                        cmd.Parameters.AddWithValue("@pharmID", User.Id);
                        cmd.Parameters.AddWithValue("patientID", receiverID);
                        break;
                    case SEND_REFILL_REQUEST_ACCEPT_NOTICE_TYPE:
                        sql = @"INSERT INTO DixonNotice (noticeType, noticeStatus, sentDate, message, pharmacySender, patientReceiver)
                        VALUES ('Refill Request Accepted', 'New', CURRENT_DATE, @message, @pharmID, @patientID);";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@message", message);
                        cmd.Parameters.AddWithValue("@pharmID", User.Id);
                        cmd.Parameters.AddWithValue("@patientID", receiverID);
                        break;
                    case SEND_REFILL_REQUEST_REJECT_NOTICE_TYPE:
                        sql = @"INSERT INTO DixonNotice (noticeType, noticeStatus, sentDate, message, pharmacySender, patientReceiver)
                        VALUES ('Refill Request Denied', 'New', CURRENT_DATE, @message, @pharmID, @patientID);";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@message", message);
                        cmd.Parameters.AddWithValue("@pharmID", User.Id);
                        cmd.Parameters.AddWithValue("@patientID", receiverID);
                        break;
                    case SEND_PHONECALL_REQUEST_NOTICE_TYPE:
                        sql = @"INSERT INTO DixonNotice (noticeType, noticeStatus, sentDate, message, patientSender, doctorReceiver)
                        VALUES ('Phone Call Request', 'New', CURRENT_DATE, @message, @pharmID, @patientID);";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@message", message);
                        cmd.Parameters.AddWithValue("@pharmID", User.Id);
                        cmd.Parameters.AddWithValue("@patientID", receiverID);
                        break;
                    default:
                        sql = "";
                        cmd = new MySqlCommand(sql, conn);
                        break;
                }
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }
    }
}

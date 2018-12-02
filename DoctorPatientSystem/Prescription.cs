using System;
using System.Collections;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorPatientSystem
{
    class Prescription
    {

        private int id;
        private string date;
        private string patientName;
        private string prescriberName;
        private string status;
        private string pharmacyName;
        private int refills;
        private int remainingRefills;
        private int patientId;
        private string patientBirthDate;
        private int doctorId;
        private int pharmacyId;
        private ArrayList medicines = new ArrayList();
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
        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }
        public string PatientName
        {
            get
            {
                return patientName;
            }

            set
            {
                patientName = value;
            }
        }
        public string PrescriberName
        {
            get
            {
                return prescriberName;
            }

            set
            {
                prescriberName = value;
            }
        }
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
        public int Refills
        {
            get
            {
                return refills;
            }

            set
            {
                refills = value;
            }
        }
        public int RemainingRefills
        {
            get
            {
                return remainingRefills;
            }

            set
            {
                remainingRefills = value;
            }
        }
        public int PatientId
        {
            get
            {
                return patientId;
            }

            set
            {
                patientId = value;
            }
        }
        public ArrayList Medicines
        {
            get
            {
                return medicines;
            }

            set
            {
                medicines = value;
            }
        }
        public string PatientBirthDate
        {
            get
            {
                return patientBirthDate;
            }

            set
            {
                patientBirthDate = value;
            }
        }
        public static int NewPrescriptionCount
        {
            get
            {
                return newPrescriptionCount;
            }

            set
            {
                newPrescriptionCount = value;
            }
        }
        public string PharmacyName
        {
            get
            {
                return pharmacyName;
            }

            set
            {
                pharmacyName = value;
            }
        }
        public int DoctorId
        {
            get
            {
                return doctorId;
            }

            set
            {
                doctorId = value;
            }
        }
        public int PharmacyId
        {
            get
            {
                return pharmacyId;
            }

            set
            {
                pharmacyId = value;
            }
        }

        private static int newPrescriptionCount;
        private static ArrayList prescriptions = new ArrayList();


        public static ArrayList displayPrescriptions()
        {
            return prescriptions;
        }
        public ArrayList displayMedicines()
        {
            return Medicines;
        }

        /// <summary>
        /// Adds list of medicines to the Medicines property of prescription.
        /// </summary>
        public void retrieveMedicines()
        {
            DataTable table = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT m.name, m.quantity, m.dosage, m.route, m.instructions " +
                            "FROM DixonPrescription pr JOIN DixonMedicine m ON m.prescriptionID = pr.id " +
                            "WHERE pr.id = @id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", Id);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(table);
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            ArrayList medicines = new ArrayList();
            foreach (DataRow row in table.Rows)
            {
                Medicine medicine = new Medicine();
                medicine.Name = row["name"].ToString();
                medicine.Quantity = (int)row["quantity"];
                medicine.Dosage = row["dosage"].ToString();
                medicine.Route = row["route"].ToString();
                medicine.Instructions = row["instructions"].ToString();
                medicines.Add(medicine);
            }
            Medicines = medicines;
        }
        /// <summary>
        /// Execute SQL query to create a refill request
        /// </summary>
        public void createRefillRequest(int prescriptionID)
        {
            DataTable table = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql;
                sql = @"INSERT INTO DixonRefillRequest (dateRequested, refillRequestStatus, prescriptionID, patientID)
                        VALUES (CURDATE(), 'New', @pId, @id);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", User.Id);
                cmd.Parameters.AddWithValue("@pId", prescriptionID);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }
        /// <summary>
        /// Execute SQL query to retrieve prescriptions matching user's id
        /// </summary>
        public static void retrievePatientPrescriptions()
        {
            prescriptions.Clear();
            DataTable table = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql;
                    sql = @"SELECT DATE_FORMAT(pr.datefilled, ""%Y-%m-%d"") AS 'dateFilled', pr.refills, pr.remainingRefills, pr.prescriptionStatus, pr.id, d.name AS 'doctorName', p.name AS 'patientName', ph.name AS 'pharmacyName', p.patientID, d.id AS 'doctorID', ph.id AS 'pharmacyID'
                            FROM dixonPrescription pr JOIN dixondoctor d ON pr.doctorID = d.id 
                            JOIN dixonpharmacy ph ON pr.id = ph.id
                            JOIN dixonpatient p ON pr.id = p.patientid
                            WHERE pr.patientID = @id";
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

            foreach (DataRow row in table.Rows)
            {
                Prescription newPrescription = new Prescription();
                newPrescription.doctorId = (int)row["doctorID"];
                newPrescription.pharmacyId = (int)row["pharmacyID"];
                newPrescription.Date = row["dateFilled"].ToString();
                newPrescription.Refills = (int)row["refills"];
                newPrescription.RemainingRefills = (int)row["remainingRefills"];
                newPrescription.Status = row["prescriptionStatus"].ToString();
                newPrescription.PatientName = row["patientName"].ToString();
                newPrescription.PatientId = (int)row["patientID"];
                newPrescription.PrescriberName = row["doctorName"].ToString();
                newPrescription.PharmacyName = row["pharmacyName"].ToString();
                newPrescription.Id = (int)row["id"];
                prescriptions.Add(newPrescription);
            }
        }
    }
}

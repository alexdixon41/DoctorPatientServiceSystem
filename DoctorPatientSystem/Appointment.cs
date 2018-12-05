using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;

namespace DoctorPatientSystem
{
    class Appointment
    {
		private static ArrayList appointmentList = new ArrayList();

		private int id;
		private string startTime;
        private string patientName;
        private string patientID;
        private string doctorName;
        private string doctorID;
        private string status;
		
        public string StartTime
        {
            get
            {
                return startTime;
            }

            set
            {
                startTime = value;
            }
        }
		public int ID
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
        public string PatientID
        {
            get
            {
                return patientID;
            }

            set
            {
                patientID = value;
            }
        }
        public string DoctorName
        {
            get
            {
                return doctorName;
            }

            set
            {
                doctorName = value;
            }
        }
        public string DoctorID
        {
            get
            {
                return doctorID;
            }

            set
            {
                doctorID = value;
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

        public static void createAppointment(int doctorID, int patientID, string time, string status)
        {
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = @"INSERT INTO DixonAppointment (appointmentTime, doctorID, patientID, appointmentStatus)
                            VALUES(@time, @docID, @paID, @status);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@time", time);
                cmd.Parameters.AddWithValue("@docID", doctorID);
                cmd.Parameters.AddWithValue("@paID", patientID);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

		//Returns the doctors list of appointments
		public static ArrayList displayAppointments()
		{
			return appointmentList;
		}

		//Retrieves all of a doctor's appointments from the database and stores them in appointmentList
		public static void retrieveAppointments(int doctorID)
		{
			DataTable table = new DataTable();
			string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
			MySqlConnection conn = new MySqlConnection(connStr);
			try
			{
				Console.WriteLine("Connecting to MySQL...");
				conn.Open();
				string sql = @"SELECT p.name, a.appointmentTime, a.appointmentStatus, a.id, a.patientID 
							FROM dixonpatient p join dixonappointment a on p.patientID = a.patientID join dixondoctor d on a.doctorID = d.id
							WHERE d.id = @docID AND a.appointmentTime > CURRENT_TIME() ORDER BY a.appointmentStatus DESC, a.appointmentTime";
				MySqlCommand cmd = new MySqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@docID", doctorID);
				MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
				myAdapter.Fill(table);
				Console.WriteLine("Table is ready.");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			conn.Close();

			appointmentList.Clear();
			foreach (DataRow row in table.Rows)
			{
				Appointment newAppointment = new Appointment();
				newAppointment.patientName = row["name"].ToString();
				newAppointment.startTime = row["appointmentTime"].ToString();
				newAppointment.status = row["appointmentStatus"].ToString();
				newAppointment.id = Int32.Parse(row["id"].ToString());
				newAppointment.patientID = row["patientID"].ToString();
				appointmentList.Add(newAppointment);
			}
		}

		//updates the status of the appointment to newStatus
		public void UpdateStatus(String newStatus)
		{
			status = newStatus;
			string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
			MySqlConnection conn = new MySqlConnection(connStr);
			try
			{
				Console.WriteLine("Connecting to MySQL...");
				conn.Open();
				string sql = @"UPDATE dixonappointment SET appointmentStatus = @status WHERE id = @id ";
				MySqlCommand cmd = new MySqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@id", id);
				cmd.Parameters.AddWithValue("@status", status);
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			conn.Close();
		}


	}
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DoctorPatientSystem
{
    class Appointment
    {
        private string startTime;
        private string patientName;
        private string patientID;
        private string doctorName;
        private string doctorID;
        private string status;
		private ArrayList appointmentList = new ArrayList();
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

		public static void retrieveAppointments(int doctorID)
		{
			//TO DO retrieve appointments from the database
		}

    }
}

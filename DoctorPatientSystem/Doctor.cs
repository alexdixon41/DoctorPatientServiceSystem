﻿using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorPatientSystem
{
    class Doctor
    {
        private static ArrayList doctors = new ArrayList();
        public static string[] appointmentTimes = new string[] {"09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00",
            "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30"};

        private string name;
        private int id;
        private string officeName;
        private string officeNumber;
        private ArrayList workDays = new ArrayList();
        private ArrayList appointments = new ArrayList();
        private static ArrayList pharmacies = new ArrayList();
        private static ArrayList pharmaciesId = new ArrayList();
        public ArrayList WorkDays
        {
            get
            {
                return workDays;
            }

            set
            {
                workDays = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
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
        public string OfficeName
        {
            get
            {
                return officeName;
            }

            set
            {
                officeName = value;
            }
        }
        public string OfficeNumber
        {
            get
            {
                return officeNumber;
            }

            set
            {
                officeNumber = value;
            }
        }
        public ArrayList Appointments
        {
            get
            {
                return appointments;
            }

            set
            {
                appointments = value;
            }
        }

        private static ArrayList Pharmacies
        {
            get
            {
                return pharmacies;
            }

            set
            {
                pharmacies = value;
            }
        }
        public static ArrayList PharmaciesId
        {
            get
            {
                return pharmaciesId;
            }

            set
            {
                pharmaciesId = value;
            }
        }

		/// <summary>
		/// Retrieves doctors from the database whose first or last name matches the search criteria and saves them in the doctors list
		/// </summary>
		/// <param name="sqlStr">The search criteria</param>
        public static void retrieveDoctors(string sqlStr)
        {
            doctors.Clear();
            DataTable dataTable = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=none";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = @"SELECT d.id, d.name, d.officeName, s.monday, s.tuesday, s.wednesday, s.thursday, s.friday, s.saturday, s.sunday, ph.officenumber  
                            FROM DixonDoctor d LEFT OUTER JOIN DixonPhonenumber ph ON d.phonenumber = ph.id JOIN DixonSchedule s ON s.id = d.workSchedule 
                            WHERE d.name LIKE @searchKey1 OR d.name LIKE @searchKey2";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@searchKey1", sqlStr + "%");
                cmd.Parameters.AddWithValue("@searchKey2", "% " + sqlStr + "%");
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(dataTable);
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                Doctor doctor = new Doctor();
                doctor.Name = row["name"].ToString();
                doctor.Id = (int)row["id"];
                if (row["monday"].ToString() == "True")
                {
                    doctor.WorkDays.Add(DayOfWeek.Monday);
                }
                if (row["tuesday"].ToString() == "True")
                {
                    doctor.WorkDays.Add(DayOfWeek.Tuesday);
                }
                if (row["wednesday"].ToString() == "True")
                {
                    doctor.WorkDays.Add(DayOfWeek.Wednesday);
                }
                if (row["thursday"].ToString() == "True")
                {
                    doctor.WorkDays.Add(DayOfWeek.Thursday);
                }
                if (row["friday"].ToString() == "True")
                {
                    doctor.WorkDays.Add(DayOfWeek.Friday);
                }
                if (row["saturday"].ToString() == "True")
                {
                    doctor.WorkDays.Add(DayOfWeek.Saturday);
                }
                if (row["sunday"].ToString() == "True")
                {
                    doctor.WorkDays.Add(DayOfWeek.Sunday);
                }
                doctor.OfficeNumber = row["officeNumber"].ToString();
                doctor.OfficeName = row["officeName"].ToString();
                doctors.Add(doctor);
            }
        }

		//returns the list of doctors 
        public static ArrayList displayDoctors()
        {
            return doctors;
        }

		/// <summary>
		/// Determines which doctors work on a selected day of the week and saves them in the doctors list
		/// </summary>
		/// <param name="selectedDay">The selected day of the week</param>
        public static void getAvailableDoctors(DayOfWeek selectedDay)
        {
            ArrayList availableDoctors = new ArrayList();
            foreach (Doctor doc in doctors)
            {
                if (doc.WorkDays.Contains(selectedDay))
                    availableDoctors.Add(doc);
            }
            doctors = availableDoctors;           
        }

		//Retrieves appointments on a specific date from the database and saves them in the appointments list
        public void retrieveAppointments(string date)
        {
            DataTable dataTable = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=none";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = @"SELECT DATE_FORMAT(appointmentTime, ""%H:%i"") AS 'AppointmentTime', a.doctorID, a.patientID, p.name AS 'pname', d.name
                            FROM DixonAppointment a JOIN DixonPatient p ON a.patientID = p.patientID JOIN DixonDoctor d ON a.doctorID = d.id
                            WHERE DATE_FORMAT(a.appointmentTime, ""%Y-%m-%d"") = @date;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@date", date);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(dataTable);
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                Appointment apt = new Appointment();
                apt.StartTime = row["AppointmentTime"].ToString();
                apt.DoctorID = row["doctorID"].ToString();
                apt.PatientID = row["patientID"].ToString();
                apt.PatientName = row["pname"].ToString();
                apt.DoctorName = row["name"].ToString();
                appointments.Add(apt);
            }
        }

		/// <summary>
		/// Retrieves the name of a doctor from the database
		/// </summary>
		/// <param name="docID">The ID of the doctor whose name is being retrieved</param>
		/// <returns>Returns the name of the doctor</returns>
		public static String retrieveDoctorName(int docID)
		{
			String doctorName = "";
			DataTable dataTable = new DataTable();
			string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=none";
			MySqlConnection conn = new MySqlConnection(connStr);
			try
			{
				Console.WriteLine("Connecting to MySQL...");
				conn.Open();
				string sql = @"SELECT name FROM dixondoctor where id = @id";
				MySqlCommand cmd = new MySqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@id", docID);
				MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
				myAdapter.Fill(dataTable);
				Console.WriteLine("Table is ready.");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			conn.Close();

			doctorName = dataTable.Rows[0]["name"].ToString();

			return doctorName;
		}

		/// <summary>
		/// Grants a doctor access to a patient's records and saves this access in the database
		/// </summary>
		/// <param name="doctorID">The doctor's ID</param>
		/// <param name="patientID">The patient's ID</param>
		public static void grantRecordAccess(int doctorID, int patientID)
		{
			string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=none";
			MySqlConnection conn = new MySqlConnection(connStr);
			try
			{
				Console.WriteLine("Connecting to MySQL...");
				conn.Open();
				string sql = @"INSERT INTO dixonverifieddoctor (patientID, doctorID) VALUES (@pid, @docID)";
				MySqlCommand cmd = new MySqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@docID", doctorID);
				cmd.Parameters.AddWithValue("@pid", patientID);
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			conn.Close();
		}

		//Retrieves the names and ids of pharmacies from the database 
        public static void retrievePharmacies()
        {
            pharmacies.Clear();
            pharmaciesId.Clear();
            DataTable dataTable = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=none";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = @"SELECT name, id FROM dixonpharmacy";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(dataTable);
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            foreach (DataRow row in dataTable.Rows)
            {
                Pharmacies.Add(row["name"].ToString());
                PharmaciesId.Add((int)row["id"]);
            }
            conn.Close();
        }

		//returns the list of pharmacies
        public static ArrayList displayPharmacies()
        {
            return Pharmacies;
        }

		//retrieves a doctor's schedule from the database
		public void retrieveSchedule()
		{
			DataTable dataTable = new DataTable();
			string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=none";
			MySqlConnection conn = new MySqlConnection(connStr);
			try
			{
				Console.WriteLine("Connecting to MySQL...");
				conn.Open();
				string sql = @"SELECT s.* FROM dixondoctor d JOIN dixonschedule s ON d.workSchedule = s.id WHERE d.id = @docID";
				MySqlCommand cmd = new MySqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@docID", id);
				MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
				myAdapter.Fill(dataTable);
				Console.WriteLine("Table is ready.");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			conn.Close();

			DataRow row = dataTable.Rows[0];
			if (row["monday"].ToString() == "True")
			{
				WorkDays.Add(DayOfWeek.Monday);
			}
			if (row["tuesday"].ToString() == "True")
			{
				WorkDays.Add(DayOfWeek.Tuesday);
			}
			if (row["wednesday"].ToString() == "True")
			{
				WorkDays.Add(DayOfWeek.Wednesday);
			}
			if (row["thursday"].ToString() == "True")
			{
				WorkDays.Add(DayOfWeek.Thursday);
			}
			if (row["friday"].ToString() == "True")
			{
				WorkDays.Add(DayOfWeek.Friday);
			}
			if (row["saturday"].ToString() == "True")
			{
				WorkDays.Add(DayOfWeek.Saturday);
			}
			if (row["sunday"].ToString() == "True")
			{
				WorkDays.Add(DayOfWeek.Sunday);
			}
		}

	}
}

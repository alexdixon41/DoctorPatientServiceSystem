using MySql.Data.MySqlClient;
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

        public static ArrayList displayDoctors()
        {
            return doctors;
        }

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

        public void retrieveAppointments(string date)
        {
            DataTable dataTable = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=none";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = @"SELECT DATE_FORMAT(appointmentTime, ""%H:%m"") AS 'AppointmentTime', a.doctorID, a.patientID, p.name AS 'pname', d.name
                            FROM DixonAppointment a JOIN DixonPatient p ON a.patientID = p.patientID JOIN DixonDoctor d ON a.doctorID = d.id
                            WHERE DATE_FORMAT(a.appointmentTime, ""%Y-%d-%m"") = @date;";
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
      
    }
}

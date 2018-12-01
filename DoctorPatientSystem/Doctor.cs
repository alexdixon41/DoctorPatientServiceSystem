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

        private string name;
        private int id;
        private ArrayList workDays = new ArrayList();
        private ArrayList phoneNums = new ArrayList();

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
                string sql = @"SELECT d.id, d.name, s.monday, s.tuesday, s.wednesday, s.thursday, s.friday, s.saturday, s.sunday, ph.officenumber  
                            FROM DixonDoctor d JOIN DixonSchedule s ON s.id = d.workSchedule JOIN DixonPhonenumber ph ON d.phonenumber = ph.id 
                            WHERE d.name LIKE @searchKey1 OR LIKE @searchKey2";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@searchKey1", "" + sqlStr + "%");
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
                if (!row["officenumber"].ToString().Equals(null))
                {
                    doctor.phoneNums.Add(row["officenumber"].ToString());
                }
                doctors.Add(doctor);
            }
        }

        public static ArrayList displayDoctors()
        {
            return doctors;
        }
      
    }
}

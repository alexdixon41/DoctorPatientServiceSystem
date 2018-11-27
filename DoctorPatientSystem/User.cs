using MySql.Data.MySqlClient;
using System;
using System.Data;

using System.Security.Cryptography;

namespace DoctorPatientSystem
{
    /// <summary>
    /// A user of the system. Manages user login to control what data the user can access.
    /// </summary>
    class User
    {
        public const int DOCTOR_USER_TYPE = 1;
        public const int PATIENT_USER_TYPE = 2;

        private static int type;
        private static int id;
        public static int Type
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
        public static int Id
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

        public static Boolean authenticate(int userType, string u, string p)
        {
            DataTable table = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql;
                if (userType == DOCTOR_USER_TYPE)
                    sql = "SELECT id, pword FROM DixonDoctor WHERE username = @u";
                else
                    sql = "SELECT patientID, pword FROM DixonPatient WHERE username = @u";                

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", u);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(table);
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            if (table.Rows.Count == 1)
            {
                string inputPass;
                using (MD5 md5 = MD5.Create())
                {
                    byte[] hashedBytes = md5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(p));
                    inputPass = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                }
                if (table.Rows[0]["pword"].ToString() == inputPass)
                {
                    if (userType == DOCTOR_USER_TYPE)
                        User.Id = (int)table.Rows[0]["id"];
                    else
                        User.Id = (int)table.Rows[0]["patientID"];
                    User.Type = userType;
                    return true;
                }
            }
            return false;
        }
    }
}


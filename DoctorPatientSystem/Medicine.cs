using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DoctorPatientSystem
{
    class Medicine
    {
        private string date;
        private string name;
        private int quantity;
        private string dosage;
        private string route;
        private string instructions;
        private int prescriptionID;
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
        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }
        public string Dosage
        {
            get
            {
                return dosage;
            }

            set
            {
                dosage = value;
            }
        }
        public string Route
        {
            get
            {
                return route;
            }

            set
            {
                route = value;
            }
        }
        public string Instructions
        {
            get
            {
                return instructions;
            }

            set
            {
                instructions = value;
            }
        }
        public int PrescriptionID
        {
            get
            {
                return prescriptionID;
            }

            set
            {
                prescriptionID = value;
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

        public static void createMedicine(ArrayList medicines, int prescriptionID)
        {
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                foreach (Medicine med in medicines)
                {
                    string sql;
                    sql = @"INSERT INTO Dixonmedicine (name, quantity, dosage, route, instructions, prescriptionId)
                        VALUES (@name, @quantity, @dosage, @route, @instructions, @pId);";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@name", med.name);
                    cmd.Parameters.AddWithValue("@quantity", med.quantity);
                    cmd.Parameters.AddWithValue("@dosage", med.dosage);
                    cmd.Parameters.AddWithValue("@route", med.route);
                    cmd.Parameters.AddWithValue("@instructions", med.instructions);
                    cmd.Parameters.AddWithValue("@pId", prescriptionID);
                    cmd.ExecuteNonQuery();
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }
    }
}

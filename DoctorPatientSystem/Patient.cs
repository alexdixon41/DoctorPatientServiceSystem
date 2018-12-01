using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Data;

namespace DoctorPatientSystem
{
    class Patient
    {
        private static ArrayList patients = new ArrayList();
        private ArrayList phoneNums = new ArrayList();

        private string name;
        private string birthDate;
        private int familyDoctorId;
        private int id;
        private string cellNumber;
        private string homeNumber;
        private string officeNumber;
        private string address;
        private string allergies;
        private string maritalStatus;
        private string disorders;
        private string notes;
        private int weight;
        private int height;
        private double bodyMassIndex;
        private ArrayList medicineHistory = new ArrayList();
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
        public string BirthDate
        {
            get
            {
                return birthDate;
            }

            set
            {
                birthDate = value;
            }
        }
        public int FamilyDoctorId
        {
            get
            {
                return familyDoctorId;
            }

            set
            {
                familyDoctorId = value;
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
        public string CellNumber
        {
            get
            {
                return cellNumber;
            }

            set
            {
                cellNumber = value;
            }
        }
        public string HomeNumber
        {
            get
            {
                return homeNumber;
            }

            set
            {
                homeNumber = value;
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
        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }
        public string Allergies
        {
            get
            {
                return allergies;
            }

            set
            {
                allergies = value;
            }
        }
        public string MaritalStatus
        {
            get
            {
                return maritalStatus;
            }

            set
            {
                maritalStatus = value;
            }
        }
        public string Disorders
        {
            get
            {
                return disorders;
            }

            set
            {
                disorders = value;
            }
        }
        public string Notes
        {
            get
            {
                return notes;
            }

            set
            {
                notes = value;
            }
        }
        public int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }
        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }
        public double BodyMassIndex
        {
            get
            {
                return bodyMassIndex;
            }

            set
            {
                bodyMassIndex = value;
            }
        }
        public ArrayList MedicineHistory
        {
            get
            {
                return medicineHistory;
            }

            set
            {
                medicineHistory = value;
            }
        }

        public static ArrayList displayPatients()
        {
            return patients;
        }

        public static void retrievePatients(string searchKey)
        {
            DataTable table = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = @"SELECT name, DATE_FORMAT(birthDate, ""%m-%d-%Y"") AS birthDate, patientID FROM DixonPatient 
                            WHERE name LIKE @searchKey1 OR name LIKE @searchKey2;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@searchKey1", "" + searchKey + "%");
                cmd.Parameters.AddWithValue("@searchKey2", "% " + searchKey + "%");
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(table);
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            patients.Clear();
            foreach (DataRow row in table.Rows)
            {
                Patient newPatient = new Patient();
                newPatient.Name = row["name"].ToString();
                newPatient.birthDate = row["birthDate"].ToString();
                newPatient.Id = (int)row["patientID"];
                patients.Add(newPatient);
            }
        }

        public void retrieveMedicineHistory()
        {
            DataTable table = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT m.name, DATE_FORMAT(pr.dateFilled, \"%m-%d-%Y\") AS dateFilled, m.quantity, m.dosage, m.route, " +
                            "m.instructions, m.prescriptionID " +
                            "FROM DixonPatient pa JOIN DixonPrescription pr ON pr.patientID = pa.patientID " +
                            "JOIN DixonMedicine m ON m.prescriptionID = pr.id WHERE pa.patientID = @id;";
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

            MedicineHistory.Clear();
            foreach (DataRow row in table.Rows)
            {
                Medicine medicine = new Medicine();
                medicine.Name = row["name"].ToString();
                medicine.Date = row["dateFilled"].ToString();
                medicine.Quantity = (int)row["quantity"];
                medicine.Dosage = row["dosage"].ToString();
                medicine.Route = row["route"].ToString();
                medicine.Instructions = row["instructions"].ToString();
                medicine.PrescriptionID = (int)row["prescriptionID"];
                medicineHistory.Add(medicine);
            }
        }

        public void retrieveMedicalRecord()
        {
            DataTable table = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT height, weight, maritalStatus, disorders, allergies, notes " +
                        "FROM DixonMedicalRecord WHERE patientID = @id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", Id);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MaritalStatus = reader["maritalStatus"].ToString();
                    Disorders = reader["disorders"].ToString();
                    Allergies = reader["allergies"].ToString();
                    Notes = reader["notes"].ToString();
                    Height = (int)reader["height"];
                    Weight = (int)reader["weight"];
                    BodyMassIndex = Weight * .45 / (Height * Height * .000625);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done");
        }

		public bool validateAccess(int doctorID) 
		{
			bool hasAccess = false;

			DataTable table = new DataTable();
			string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
			MySqlConnection conn = new MySqlConnection(connStr);
			try
			{
				Console.WriteLine("Connecting to MySQL...");
				conn.Open();
				string sql = "SELECT * FROM dixonverifieddoctor WHERE patientID = @pid AND doctorID = @did";
				MySqlCommand cmd = new MySqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@pid", Id);
				cmd.Parameters.AddWithValue("@did", doctorID);
				MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
				myAdapter.Fill(table);

				if (table.Rows.Count != 0)
				{
					hasAccess = true;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			conn.Close();

			return hasAccess;
		}

        public void retrievePhoneNumber(string id)
        {
            DataTable table = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT height, weight, maritalStatus, disorders, allergies, notes " +
                        "FROM DixonMedicalRecord WHERE patientID = @id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", Id);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }
    }
}

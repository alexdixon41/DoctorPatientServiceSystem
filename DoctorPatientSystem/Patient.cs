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
        public ArrayList PhoneNums

        {
            get
            {
                return phoneNums;
            }

            set
            {
                phoneNums = value;
            }
        }

		/// <summary>
		/// Returns the patients arraylist
		/// </summary>
		/// <returns>Arraylist containing the results of the patient search</returns>
        public static ArrayList displayPatients()
        {
            return patients;
        }

		/// <summary>
		/// Retrieves patients from the database whose first or last name matches the search criteria and stores the results 
		/// in the patients arraylist
		/// </summary>
		/// <param name="searchKey">Search criteria used to find a patient</param>
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

		/// <summary>
		/// Retrieves the medicines the patient has been prescribed from the database and stores them
		/// in the medicineHistory arraylist
		/// </summary>
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

		/// <summary>
		/// Retrieves the patient's medical record from the database
		/// </summary>
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

		/// <summary>
		/// Determines if a doctor has access to view a patient's medical records.
		/// </summary>
		/// <param name="doctorID">The id of the doctor wanting to access the records</param>
		/// <returns>Returns true if the doctor has access to the record and false if they do not</returns>
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

                sql = "SELECT name FROM DixonPatient WHERE patientID = @pid AND familyDoctor = @did;";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pid", Id);
                cmd.Parameters.AddWithValue("@did", doctorID);
                myAdapter = new MySqlDataAdapter(cmd);
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

		/// <summary>
		/// Sets the value of the maritalStatus, height, weight, disorders, allergies, and notes attributes
		/// to the entered values
		/// </summary>
		/// <param name="newMarStatus">The new value for maritalStatus</param>
		/// <param name="newHeight">The new value for height</param>
		/// <param name="newWeight">The new value for weight</param>
		/// <param name="newDisorders">The new value for disorders</param>
		/// <param name="newAllergies">The new value for allergies</param>
		/// <param name="newNotes">The new value for notes</param>
		public void updateMedicalRecord(String newMarStatus, int newHeight, int newWeight, String newDisorders, String newAllergies, String newNotes)
		{
			maritalStatus = newMarStatus;
			height = newHeight;
			weight = newWeight;
			disorders = newDisorders;
			allergies = newAllergies;
			notes = newNotes;

			saveMedicalRecord();
		}

		/// <summary>
		/// Saves the value of the maritalStatus, height, weight, disorders, allergies, and notes attributes to the database
		/// </summary>
		private void saveMedicalRecord()
		{
			string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
			MySqlConnection conn = new MySqlConnection(connStr);
			try
			{
				Console.WriteLine("Connecting to MySQL...");
				conn.Open();
				string sql = "UPDATE dixonmedicalrecord SET maritalStatus = @ms, disorders = @d, allergies = @a, notes = @n, weight = @w, height = @h WHERE patientID = @pid";
				MySqlCommand cmd = new MySqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@ms", maritalStatus);
				cmd.Parameters.AddWithValue("@d", disorders);
				cmd.Parameters.AddWithValue("@a", allergies);
				cmd.Parameters.AddWithValue("@n", notes);
				cmd.Parameters.AddWithValue("@w", weight);
				cmd.Parameters.AddWithValue("@h", height);
				cmd.Parameters.AddWithValue("@pid", id);

				cmd.ExecuteNonQuery();

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			conn.Close();
		}

		/// <summary>
		/// Determines if the patient has a medical record in the database
		/// </summary>
		/// <returns>True if the patient has a medical record and false if they do not</returns>
		public bool hasMedicalRecord()
		{
			bool hasRecord = false;

			DataTable table = new DataTable();
			string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
			MySqlConnection conn = new MySqlConnection(connStr);
			try
			{
				Console.WriteLine("Connecting to MySQL...");
				conn.Open();
				string sql = "SELECT patientID FROM dixonmedicalrecord WHERE patientID = @pid";
				MySqlCommand cmd = new MySqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@pid", Id);
				MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
				myAdapter.Fill(table);

				if (table.Rows.Count > 0)
				{
					hasRecord = true;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			conn.Close();

			return hasRecord;
		}

		/// <summary>
		/// Creates a new medical record in the database for an existing patient who did not have a medical record
		/// </summary>
		/// <param name="newMarStatus">Value of the maritalStatus to be saved in the database</param>
		/// <param name="newHeight">Value of the height to be saved in the database</param>
		/// <param name="newWeight">Value of the weight to be saved in the database</param>
		/// <param name="newDisorders">Value of the disorders to be saved in the database</param>
		/// <param name="newAllergies">Value of the allergies to be saved in the database</param>
		/// <param name="newNotes">Value of the notes to be saved in the database</param>
		public void createMedicalRecord(String newMarStatus, int newHeight, int newWeight, String newDisorders, String newAllergies, String newNotes)
		{
			maritalStatus = newMarStatus;
			height = newHeight;
			weight = newWeight;
			disorders = newDisorders;
			allergies = newAllergies;
			notes = newNotes;

			string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
			MySqlConnection conn = new MySqlConnection(connStr);
			try
			{
				Console.WriteLine("Connecting to MySQL...");
				conn.Open();
				string sql = @"INSERT INTO dixonmedicalrecord (patientID, maritalStatus, height, weight, disorders, allergies, notes) 
								VALUES (@pid, @ms, @h, @w, @d, @a, @n)";
				MySqlCommand cmd = new MySqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@ms", maritalStatus);
				cmd.Parameters.AddWithValue("@d", disorders);
				cmd.Parameters.AddWithValue("@a", allergies);
				cmd.Parameters.AddWithValue("@n", notes);
				cmd.Parameters.AddWithValue("@w", weight);
				cmd.Parameters.AddWithValue("@h", height);
				cmd.Parameters.AddWithValue("@pid", id);

				cmd.ExecuteNonQuery();

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			conn.Close();
		}
		
		/// <summary>
		/// Retrieves a patient's name and birthday from the database
		/// </summary>
		/// <param name="patientID">The id of the patient whose information is being retrieved</param>
		/// <returns>A patient object with attributes storing the data retrieved from the database</returns>
		public static Patient retrievePatientByID(int patientID)
		{
            Patient patient = new Patient();
            patient.Id = patientID;
            DataTable dataTable = new DataTable();
			string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=none";
			MySqlConnection conn = new MySqlConnection(connStr);
			try
			{
				Console.WriteLine("Connecting to MySQL...");
				conn.Open();
				string sql = @"SELECT name, DATE_FORMAT(birthDate, ""%Y-%m-%d"") AS 'birthDate' FROM dixonpatient where patientID = @id";
				MySqlCommand cmd = new MySqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@id", patientID);
				MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
				myAdapter.Fill(dataTable);
				Console.WriteLine("Table is ready.");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			conn.Close();

			patient.Name = dataTable.Rows[0]["name"].ToString();
            patient.BirthDate = dataTable.Rows[0]["birthDate"].ToString();
            
			return patient;
		}

		/// <summary>
		/// Retrieves a patient's phone number from the database
		/// </summary>
		/// <param name="id">The id of the patient whose phone number is being retrieved</param>
        public void retrievePhoneNumber(int id)
        {
            
            DataTable table = new DataTable();
            string connStr = "server=csdatabase.eku.edu;user=stu_csc340;database=csc340_db;port=3306;password=Colonels18;SSLMode=None";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = @"SELECT p.name, ph.homeNumber, ph.cellNumber, ph.officeNumber 
                                FROM Dixonpatient p JOIN Dixonphonenumber ph ON p.phonenumber = ph.ID
                                WHERE p.patientid = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    if (!(reader["homeNumber"].ToString().Equals("")))
                    {
                        PhoneNums.Add(reader["homeNumber"].ToString());
                    }
                    if (!(reader["cellNumber"].ToString().Equals("")))
                    {
                        PhoneNums.Add(reader["cellNumber"].ToString());
                    }
                    if (!(reader["officeNumber"].ToString().Equals("")))
                    {
                        PhoneNums.Add(reader["officeNumber"].ToString());
                    }
                    name = reader["name"].ToString();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done");
        }
    }
}

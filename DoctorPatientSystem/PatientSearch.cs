using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace DoctorPatientSystem
{
    public partial class PatientSearch : UserControl
    {
		private ArrayList patientResultsList = new ArrayList();
		private Patient selectedPatient = new Patient();
		private Doctor doctorUser = new Doctor();                
		private ArrayList appointmentTimes = new ArrayList();
        private int checkBoxAmnt = 1;            //number of medicines to add to a prescription
		public PatientSearch()
        {
            InitializeComponent();
        }

        //view information for the selected patient
        private void viewPatientInformation_Click(object sender, EventArgs e)
        {
			if (patientView.SelectedIndices.Count != 0)
			{
                selectedPatient = (Patient)(patientResultsList[patientView.SelectedItems[0].Index]);   //save the patient selected from the list
                displayPatientInfo(selectedPatient);
                determineDoctorAccess(selectedPatient);                     //enable or disable buttons according to access level of user for patient
                basicPatientInfoPanel.Show();
				patientSearchPanel.Hide();
			}
        }

        //reset this UserControl to default state at patient search panel
		public void resetPatientSearch()
		{
			patientView.Items.Clear();
			patientSearchTextBox.Text = "Search for a patient";
			patientSearchPanel.Show();
			basicPatientInfoPanel.Hide();
			updateRecordPanel.Hide();
			viewMedicalRecordPanel.Hide();
		}

        //search for patients by name
        private void nameSearch_Click(object sender, EventArgs e)
        {
            if (patientSearchTextBox.Text.Equals("Search for a patient"))
            {
                patientSearchTextBox.Text = "";
            }
            patientView.Items.Clear();
			Patient.retrievePatients(patientSearchTextBox.Text);       //retrieve patients matching search field
			patientResultsList = Patient.displayPatients();        
			int i = 0;
			foreach (Patient patient in patientResultsList)            //add name and birthdate of each patient to listview
			{
				patientView.Items.Add(patient.Name);
				patientView.Items[i].SubItems.Add(patient.BirthDate);
				i++;
			}
        }

        //show name and birth date of selected patient on patient submenu
		private void displayPatientInfo(Patient selectedPatient)
		{
			patientNameLabel.Text = selectedPatient.Name;
			patientDOBLabel.Text = selectedPatient.BirthDate;
		}

        //determine the access level of the doctor user for the selected patient
		private void determineDoctorAccess(Patient selectedPatient)
		{
			bool hasAccess = selectedPatient.validateAccess(User.Id);    //check if the doctor has been verified to access patient records
			bool hasRecord = selectedPatient.hasMedicalRecord();         //check if the patient currently has records

            //show or hide relevant menu buttons
            if (hasAccess && hasRecord)
			{
				viewMedicalHistoryButton.Show();
                createPrescriptionButton.Show();
				requestMedicalHistoryButton.Hide();
				createMedicalRecordButton.Hide();
			}
			else if (hasAccess && !hasRecord)
			{
				createMedicalRecordButton.Show();
                createPrescriptionButton.Show();
                requestMedicalHistoryButton.Hide();
				viewMedicalHistoryButton.Hide();
			}
			else
			{
				requestMedicalHistoryButton.Show();
                createPrescriptionButton.Show();
                viewMedicalHistoryButton.Hide();
				createMedicalRecordButton.Hide();
			}
		}

        //return to the search panel
		private void backButton_Click(object sender, EventArgs e)
		{
				basicPatientInfoPanel.Hide();
				patientSearchPanel.Show();
		}

        //view the medical history of the selected patient
		private void viewMedicalHistoryButton_Click(object sender, EventArgs e)
		{
            selectedPatient.retrieveMedicalRecord();           //retrieve the selected patient's medical record
            selectedPatient.retrieveMedicineHistory();         //retrieve the selected patient's medicine history (all medicines they have taken in the past)
            displayMedicalRecord();
            displayMedicineHistory();
            basicPatientInfoPanel.Hide();
			viewMedicalRecordPanel.Show();
		}

        //display the medical record in the panel
		private void displayMedicalRecord()
		{
			medicalRecordListView.Items.Clear();
			patientNameRecordLabel.Text = selectedPatient.Name;
			medicalRecordListView.Items.Add("Date of Birth: " + selectedPatient.BirthDate);
			medicalRecordListView.Items.Add("Height: " + (selectedPatient.Height == 0 ? "" : selectedPatient.Height.ToString()));
			medicalRecordListView.Items.Add("Weight: " + (selectedPatient.Weight == 0 ? "" : selectedPatient.Weight.ToString()));
			medicalRecordListView.Items.Add("Marital Status: " + selectedPatient.MaritalStatus);
			medicalRecordListView.Items.Add("Disorders: " + selectedPatient.Disorders);
			medicalRecordListView.Items.Add("Allergies: " + selectedPatient.Allergies);
			medicalRecordListView.Items.Add("Notes: " + selectedPatient.Notes);
		}

        //display each medicine the selected patient has taken
		private void displayMedicineHistory()
		{
			medicineHistoryListView.Items.Clear();
			int i = 0;
			foreach (Medicine med in selectedPatient.MedicineHistory)          //add details for each medicine in the patient's medicine history to the listview
			{
				medicineHistoryListView.Items.Add(med.Name);
				medicineHistoryListView.Items[i].SubItems.Add(med.Dosage);
				medicineHistoryListView.Items[i].SubItems.Add(med.Date);
				i++;
			}
			
		}

        //request the selected patient's access to their medical records
		private void requestMedicalHistoryButton_Click(object sender, EventArgs e)
		{
            if (new ConfirmationPopup("Are you sure you want to request to view " + selectedPatient.Name + "'s medical records?", "")
                .ShowDialog() == DialogResult.OK)
            {
                String message = Doctor.retrieveDoctorName(User.Id) + " wants to view your medical records.";
                Notice.sendNotice(selectedPatient.Id, message, Notice.SEND_RECORD_REQUEST_NOTICE_TYPE);
                new AlertDialog("Your record request has been sent.").ShowDialog();
            }
		}

        //return to the patient submenu
		private void backToBasicInfoButton_Click(object sender, EventArgs e)
		{
            viewMedicalRecordPanel.Hide();
            basicPatientInfoPanel.Show();
            determineDoctorAccess(selectedPatient);
		}

        //update the patient's medical record
		private void updateMedicalRecordButton_Click(object sender, EventArgs e)
		{
			updateRecordPanel.Show();
			viewMedicalRecordPanel.Hide();
			displayEditableInformation();
			updateOrCreateLabel.Text = "Update Medical Record";
			createButton.Hide();
            submitUpdateButton.Show();
		}

        //fill in text boxes with the patient's current records so the doctor can edit each field
		private void displayEditableInformation()
		{
			maritalStatusTextBox.Text = selectedPatient.MaritalStatus;            
			heightTextBox.Text = (selectedPatient.Height == 0 ? "" : selectedPatient.Height.ToString());
			weightTextBox.Text = (selectedPatient.Weight == 0 ? "" : selectedPatient.Weight.ToString());
			disordersTextBox.Text = selectedPatient.Disorders;
			allergiesTextBox.Text = selectedPatient.Allergies;
			notesTextBox.Text = selectedPatient.Notes;
		}

        //return to the patient's medical record
		private void backToMedicalRecord_Click(object sender, EventArgs e)
		{
			updateRecordPanel.Hide();
			viewMedicalRecordPanel.Show();
		}

        //submit an update to the patient's medical records
		private void submitUpdateButton_Click(object sender, EventArgs e)
		{
            if (new ConfirmationPopup("Are you sure you want to update " + selectedPatient.Name + "'s medical records?", "")
                .ShowDialog() == DialogResult.OK)
            {
                String ms = maritalStatusTextBox.Text;
                int h;
                if (heightTextBox.Text.Equals(""))
                    h = 0;
                else
                    h = Int32.Parse(heightTextBox.Text);
                int w;
                if (weightTextBox.Text.Equals(""))
                    w = 0;
                else
                    w = Int32.Parse(weightTextBox.Text);
                String d = disordersTextBox.Text;
                String a = allergiesTextBox.Text;
                String n = notesTextBox.Text;
                selectedPatient.updateMedicalRecord(ms, h, w, d, a, n);
                displayMedicalRecord(); //display updated info
                updateRecordPanel.Hide();
                viewMedicalRecordPanel.Show();
            }
		}

        //display panel to create a new medical record for the selected patient
		private void createMedicalRecordButton_Click(object sender, EventArgs e)
		{
            updateOrCreateLabel.Text = "Create Medical Record";            
            basicPatientInfoPanel.Hide();
            updateRecordPanel.Show();
            submitUpdateButton.Hide();
            createButton.Show();
        }

        //create the new medical record for the selected patient
		private void createButton_Click(object sender, EventArgs e)
		{            
            if (new ConfirmationPopup("Are you sure you want to create a new medical record for this patient?", "")
                .ShowDialog() == DialogResult.OK)
            {              
                String ms = maritalStatusTextBox.Text;
                int h;
                if (heightTextBox.Text.Equals(""))
                    h = 0;
                else
                    h = Int32.Parse(heightTextBox.Text);
                int w;
                if (weightTextBox.Text.Equals(""))
                    w = 0;
                else
                    w = Int32.Parse(weightTextBox.Text);
                String d = disordersTextBox.Text;
                String a = allergiesTextBox.Text;
                String n = notesTextBox.Text;
                selectedPatient.createMedicalRecord(ms, h, w, d, a, n);
                displayMedicalRecord(); //display newly created record
                updateRecordPanel.Hide();
                viewMedicalRecordPanel.Show();
                createMedicalRecordButton.Hide();
                updateMedicalRecordButton.Show();
            }
		}

        //display panel to create a new appointment
        private void createAppointmentButton_Click(object sender, EventArgs e)
        {
			doctorUser.Id = User.Id;
			doctorUser.retrieveSchedule();
			showAvailableAppointmentTimes();
            basicPatientInfoPanel.Hide();
			createAppointmentPanel.Show();
		}

        //display panel to create a new prescription
        private void createPrescriptionButton_Click(object sender, EventArgs e)
        {
            medicinePanel2.Hide();
            medicinePanel3.Hide();
            medicinePanel4.Hide();
            checkBox2.Show();
            checkBox3.Hide();
            checkBox4.Hide();

            pharmacyListBox.Items.Clear();   
            Doctor.retrievePharmacies();                         //retrieve list of pharmacies
            foreach (string s in Doctor.displayPharmacies())     //show pharmacy names
            {
                pharmacyListBox.Items.Add(s);
            }
            basicPatientInfoPanel.Hide();
            createPrescriptionPanel.Show();
        }
   
        //return to patient submenu
		private void backFromCreateAppointmentButton_Click(object sender, EventArgs e)
		{
			createAppointmentPanel.Hide();
			basicPatientInfoPanel.Show();
		}

        //create the new appointment for the selected patient
		private void confirmAppointmentButton_Click(object sender, EventArgs e)
		{
            if (availableAppointmentsListBox.SelectedIndices.Count != 0)
            {
                if (new ConfirmationPopup("Are you sure you want to make this appointment?",
                   "Appointment with " + selectedPatient.Name + " at " + availableAppointmentsListBox.SelectedItem + " on "
                   + appointmentDateTimePicker.Text).ShowDialog() == DialogResult.OK)
                {
                    //Create new appointment
                    DateTime date = Convert.ToDateTime(appointmentDateTimePicker.Text);
                    DateTime time = Convert.ToDateTime(availableAppointmentsListBox.SelectedItem);
                    date = date.AddHours(time.Hour);
                    date = date.AddMinutes(time.Minute);
                    Appointment.createAppointment(User.Id, selectedPatient.Id, date.ToString("yyyy-MM-dd HH:mm:ss"), "Accepted");

                    //Display confirmation
                    new AlertDialog("The appointment was made.").ShowDialog();
                }

                //send notice to patient
                String message = Doctor.retrieveDoctorName(User.Id) + " has made an appointment for you at " + availableAppointmentsListBox.SelectedItem + " on " + appointmentDateTimePicker.Text;
                Notice.sendNotice(selectedPatient.Id, message, Notice.SEND_NEW_APPOINTMENT_NOTICE_TYPE);
            }
		}

        //show all times when the doctor has no appointments
		private void appointmentDateTimePicker_ValueChanged(object sender, EventArgs e)
		{
			showAvailableAppointmentTimes();
		}

		//displays all the available times the doctor has for an appointment in the listbox
		private void showAvailableAppointmentTimes()
		{
			availableAppointmentsListBox.Items.Clear();
			if (doctorUser.WorkDays.Contains(appointmentDateTimePicker.Value.DayOfWeek))
			{
				//show available appointment times in listbox
				appointmentTimes.Clear();
				doctorUser.retrieveAppointments(appointmentDateTimePicker.Value.ToString("yyyy-MM-dd"));
				foreach (string s in Doctor.appointmentTimes)
				{
					appointmentTimes.Add(s);
				}
				foreach (string s in Doctor.appointmentTimes)
				{
					foreach (Appointment apt in doctorUser.Appointments)
					{
						if (apt.StartTime.Equals(s))
							appointmentTimes.Remove(s);
					}
				}
				foreach (string s in appointmentTimes)
				{
					DateTime d = Convert.ToDateTime(s);
					availableAppointmentsListBox.Items.Add(d.ToShortTimeString());
				}
			}
		}

        //return to patient submenu
        private void backToBasicPatientInfoPanel_Click(object sender, EventArgs e)
        {
            createPrescriptionPanel.Hide();
            basicPatientInfoPanel.Show();
        }

        //add a medicine row when checkbox is checked
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                medicinePanel1.Show();
                checkBox2.Show();
                checkBoxAmnt++;
            }
            else
            {
                medicinePanel1.Hide();
                checkBox2.Hide();
                checkBoxAmnt--;
            }
        }

        //add a medicine row when checkbox changed
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                medicinePanel2.Show();
                checkBox3.Show();
                checkBoxAmnt++;
            }
            else
            {
                medicinePanel2.Hide();
                checkBox3.Hide();
                checkBoxAmnt--;
            }
        }

        //add a medicine row when checkbox checked
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                medicinePanel3.Show();
                checkBox4.Show();
                checkBoxAmnt++;
            }
            else
            {
                medicinePanel3.Hide();
                checkBox4.Hide();
                checkBoxAmnt--;
            }
        }

        //add a medicine row when checkbox checked
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                medicinePanel4.Show();
                checkBoxAmnt++;
            }
            else
            {
                medicinePanel4.Hide();
                checkBoxAmnt--;
            }
        }

        //clear default text and change color to black when search box clicked
        private void patientSearchTextBox_Click(object sender, EventArgs e)
        {
            patientSearchTextBox.Text = "";
            patientSearchTextBox.ForeColor = Color.Black;
        }

        //create the new prescription 
        private void addPrescription_Click(object sender, EventArgs e)
        {
            Medicine medicine1 = new Medicine();
            Medicine medicine2 = new Medicine();
            Medicine medicine3 = new Medicine();
            Medicine medicine4 = new Medicine();
            ArrayList medicines = new ArrayList();
            switch (checkBoxAmnt)
            {
                case 1:
                    if (string.IsNullOrEmpty(medName1.Text))
                    {
                        new AlertDialog("You're missing some information. Please be sure to fill out all forms throughout.").ShowDialog();
                    } else {
                        medicine1.Name = medName1.Text;
                        medicine1.Route = routeText1.Text;
                        medicine1.Quantity = (int)amntUpDown1.Value;
                        medicine1.Instructions = instructionText1.Text;
                        medicine1.Dosage = dosageTextbox1.Text;
                        medicines.Add(medicine1);
                        
                        Medicine.createMedicine(medicines, Prescription.createPrescription((int)Doctor.PharmaciesId[pharmacyListBox.SelectedIndex], (int)numericUpDownRefills.Value, selectedPatient.Id));
                        new AlertDialog("Your prescription has been made.").ShowDialog();
                    }
                    break;
                case 2:
                    if (string.IsNullOrEmpty(medName1.Text) || string.IsNullOrEmpty(medName2.Text))
                    {
                        new AlertDialog("You're missing some information. Please be sure to fill out all forms throughout.").ShowDialog();
                    }
                    else {
                        medicine1.Name = medName1.Text;
                        medicine1.Route = routeText1.Text;
                        medicine1.Quantity = (int)amntUpDown1.Value;
                        medicine1.Instructions = instructionText1.Text;
                        medicine1.Dosage = dosageTextbox1.Text;
                        medicine2.Name = medName2.Text;
                        medicine2.Route = routeText2.Text;
                        medicine2.Quantity = (int)amntUpDown2.Value;
                        medicine2.Instructions = instructionText2.Text;
                        medicine2.Dosage = dosageTextbox2.Text;
                        medicines.Add(medicine1);
                        medicines.Add(medicine2);
                        Medicine.createMedicine(medicines, Prescription.createPrescription((int)Doctor.PharmaciesId[pharmacyListBox.SelectedIndex], (int)numericUpDownRefills.Value, selectedPatient.Id));
                        new AlertDialog("Your prescription has been made.").ShowDialog();
                    }
                    break;
                case 3:
                    if (string.IsNullOrEmpty(medName1.Text) || string.IsNullOrEmpty(medName2.Text) || string.IsNullOrEmpty(medName3.Text))
                    {
                        new AlertDialog("You're missing some information. Please be sure to fill out all forms throughout.").ShowDialog();
                    } else {
                        medicine1.Name = medName1.Text;
                        medicine1.Route = routeText1.Text;
                        medicine1.Quantity = (int)amntUpDown1.Value;
                        medicine1.Instructions = instructionText1.Text;
                        medicine1.Dosage = dosageTextbox1.Text;
                        medicine2.Name = medName2.Text;
                        medicine2.Route = routeText2.Text;
                        medicine2.Quantity = (int)amntUpDown2.Value;
                        medicine2.Instructions = instructionText2.Text;
                        medicine2.Dosage = dosageTextbox2.Text;
                        medicine3.Name = medName3.Text;
                        medicine3.Route = routeText3.Text;
                        medicine3.Quantity = (int)amntUpDown3.Value;
                        medicine3.Instructions = instructionText3.Text;
                        medicine3.Dosage = dosageTextbox3.Text;
                        medicines.Add(medicine1);
                        medicines.Add(medicine2);
                        medicines.Add(medicine3);
                        Medicine.createMedicine(medicines, Prescription.createPrescription((int)Doctor.PharmaciesId[pharmacyListBox.SelectedIndex], (int)numericUpDownRefills.Value, selectedPatient.Id));
                        new AlertDialog("Your prescription has been made.").ShowDialog();
                    }
                    break;
                case 4:
                    if (string.IsNullOrEmpty(medName1.Text) || string.IsNullOrEmpty(medName2.Text) || string.IsNullOrEmpty(medName3.Text) || string.IsNullOrEmpty(medName4.Text))
                    {
                        new AlertDialog("You're missing some information. Please be sure to fill out all forms throughout.").ShowDialog();
                    } else {
                        medicine1.Name = medName1.Text;
                        medicine1.Route = routeText1.Text;
                        medicine1.Quantity = (int)amntUpDown1.Value;
                        medicine1.Instructions = instructionText1.Text;
                        medicine1.Dosage = dosageTextbox1.Text;
                        medicine2.Name = medName2.Text;
                        medicine2.Route = routeText2.Text;
                        medicine2.Quantity = (int)amntUpDown2.Value;
                        medicine2.Instructions = instructionText2.Text;
                        medicine2.Dosage = dosageTextbox2.Text;
                        medicine3.Name = medName3.Text;
                        medicine3.Route = routeText3.Text;
                        medicine3.Quantity = (int)amntUpDown3.Value;
                        medicine3.Instructions = instructionText3.Text;
                        medicine3.Dosage = dosageTextbox3.Text;
                        medicine4.Name = medName4.Text;
                        medicine4.Route = routeText4.Text;
                        medicine4.Quantity = (int)amntUpDown4.Value;
                        medicine4.Instructions = instructionText4.Text;
                        medicine4.Dosage = dosageTextBox4.Text;
                        medicines.Add(medicine1);
                        medicines.Add(medicine2);
                        medicines.Add(medicine3);
                        medicines.Add(medicine4);
                        Medicine.createMedicine(medicines, Prescription.createPrescription((int)Doctor.PharmaciesId[pharmacyListBox.SelectedIndex], (int)numericUpDownRefills.Value, selectedPatient.Id));
                        new AlertDialog("Your prescription has been made.").ShowDialog();
                    }
                    break;
                default:
                    new AlertDialog("You must add at least one medicine to create a prescription.").ShowDialog();
                    break;
            }
            
        }
    }
}

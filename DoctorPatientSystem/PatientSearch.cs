﻿using System;
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
        private int checkBoxAmnt = 1;
		public PatientSearch()
        {
            InitializeComponent();
        }
        private void viewPatientInformation_Click(object sender, EventArgs e)
        {
			if (patientView.SelectedIndices.Count != 0)
			{
                selectedPatient = (Patient)(patientResultsList[patientView.SelectedItems[0].Index]);
                displayPatientInfo(selectedPatient);
                determineDoctorAccess(selectedPatient);
                basicPatientInfoPanel.Show();
				patientSearchPanel.Hide();
			}
        }

		public void resetPatientSearch()
		{
			patientView.Items.Clear();
			patientSearchTextBox.Text = "Search for a patient";
			patientSearchPanel.Show();
			basicPatientInfoPanel.Hide();
			updateRecordPanel.Hide();
			viewMedicalRecordPanel.Hide();
		}

        private void nameSearch_Click(object sender, EventArgs e)
        {
            if (patientSearchTextBox.Text.Equals("Search for a patient"))
            {
                patientSearchTextBox.Text = "";
            }
            patientView.Items.Clear();
			Patient.retrievePatients(patientSearchTextBox.Text);
			patientResultsList = Patient.displayPatients();
			int i = 0;
			foreach (Patient patient in patientResultsList)
			{
				patientView.Items.Add(patient.Name);
				patientView.Items[i].SubItems.Add(patient.BirthDate);
				i++;
			}
        }

		private void displayPatientInfo(Patient selectedPatient)
		{
			patientNameLabel.Text = selectedPatient.Name;
			patientDOBLabel.Text = selectedPatient.BirthDate;
		}

		private void determineDoctorAccess(Patient selectedPatient)
		{
			bool hasAccess = selectedPatient.validateAccess(User.Id);
			bool hasRecord = selectedPatient.hasMedicalRecord();

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

		private void backButton_Click(object sender, EventArgs e)
		{
				basicPatientInfoPanel.Hide();
				patientSearchPanel.Show();
		}

		private void viewMedicalHistoryButton_Click(object sender, EventArgs e)
		{
            selectedPatient.retrieveMedicalRecord();
            selectedPatient.retrieveMedicineHistory();
            displayMedicalRecord();
            displayMedicineHistory();
            basicPatientInfoPanel.Hide();
			viewMedicalRecordPanel.Show();
		}

		private void displayMedicalRecord()
		{
			medicalRecordListView.Items.Clear();
			patientNameRecordLabel.Text = selectedPatient.Name;
			medicalRecordListView.Items.Add("Date of Birth: " + selectedPatient.BirthDate);
			medicalRecordListView.Items.Add("Height: " + selectedPatient.Height);
			medicalRecordListView.Items.Add("Weight: " + selectedPatient.Weight);
			medicalRecordListView.Items.Add("Marital Status: " + selectedPatient.MaritalStatus);
			medicalRecordListView.Items.Add("Disorders: " + selectedPatient.Disorders);
			medicalRecordListView.Items.Add("Allergies: " + selectedPatient.Allergies);
			medicalRecordListView.Items.Add("Notes: " + selectedPatient.Notes);
		}

		private void displayMedicineHistory()
		{
			medicineHistoryListView.Items.Clear();
			int i = 0;
			foreach (Medicine med in selectedPatient.MedicineHistory)
			{
				medicineHistoryListView.Items.Add(med.Name);
				medicineHistoryListView.Items[i].SubItems.Add(med.Dosage);
				medicineHistoryListView.Items[i].SubItems.Add(med.Date);
				i++;
			}
			
		}

		private void requestMedicalHistoryButton_Click(object sender, EventArgs e)
		{
            //TODO add confirmation

			String message = Doctor.retrieveDoctorName(User.Id) + " wants to view your medical records.";
			Notice.sendNotice(selectedPatient.Id, message, 7);
			new AlertDialog("Your record request has been sent.").ShowDialog();
		}

		private void backToBasicInfoButton_Click(object sender, EventArgs e)
		{
			basicPatientInfoPanel.Show();
			viewMedicalRecordPanel.Hide();
		}

		private void updateMedicalRecordButton_Click(object sender, EventArgs e)
		{
			updateRecordPanel.Show();
			viewMedicalRecordPanel.Hide();
			displayEditableInformation();
			updateOrCreateLabel.Text = "Update Medical Record";
			createButton.Hide();
			updateMedicalRecordButton.Show();
		}

		private void displayEditableInformation()
		{
			maritalStatusTextBox.Text = selectedPatient.MaritalStatus;
			heightTextBox.Text = selectedPatient.Height.ToString();
			weightTextBox.Text = selectedPatient.Weight.ToString();
			disordersTextBox.Text = selectedPatient.Disorders;
			allergiesTextBox.Text = selectedPatient.Allergies;
			notesTextBox.Text = selectedPatient.Notes;
		}

		private void backToMedicalRecord_Click(object sender, EventArgs e)
		{
			updateRecordPanel.Hide();
			viewMedicalRecordPanel.Show();
		}

		private void submitUpdateButton_Click(object sender, EventArgs e)
		{
            if (new ConfirmationPopup("Are you sure you want to update " + selectedPatient.Name + "'s medical records?", "")
                .ShowDialog() == DialogResult.OK)
            {
                String ms = maritalStatusTextBox.Text;
                int h = Int32.Parse(heightTextBox.Text);
                int w = Int32.Parse(weightTextBox.Text);
                String d = disordersTextBox.Text;
                String a = allergiesTextBox.Text;
                String n = notesTextBox.Text;
                selectedPatient.updateMedicalRecord(ms, h, w, d, a, n);
                displayMedicalRecord(); //display updated info
                updateRecordPanel.Hide();
                viewMedicalRecordPanel.Show();
            }
		}

		private void createMedicalRecordButton_Click(object sender, EventArgs e)
		{
            updateOrCreateLabel.Text = "Create Medical Record";
            updateMedicalRecordButton.Hide();
            createMedicalRecordButton.Show();
            basicPatientInfoPanel.Hide();
            updateRecordPanel.Show();
		}

		private void createButton_Click(object sender, EventArgs e)
		{
            if (new ConfirmationPopup("Are you sure you want to create a new medical record for this patient?", "")
                .ShowDialog() == DialogResult.OK)
            {
                String ms = maritalStatusTextBox.Text;
                int h = Int32.Parse(heightTextBox.Text);
                int w = Int32.Parse(weightTextBox.Text);
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

        private void createAppointmentButton_Click(object sender, EventArgs e)
        {
			doctorUser.Id = User.Id;
			doctorUser.retrieveSchedule();
			showAvailableAppointmentTimes();
            basicPatientInfoPanel.Hide();
			createAppointmentPanel.Show();
		}

        private void createPrescriptionButton_Click(object sender, EventArgs e)
        {
            medicinePanel2.Hide();
            medicinePanel3.Hide();
            medicinePanel4.Hide();
            checkBox2.Show();
            checkBox3.Hide();
            checkBox4.Hide();
            Doctor.retrievePharmacies();
            fillpharmacies(Doctor.displayPharmacies());
            basicPatientInfoPanel.Hide();
            createPrescriptionPanel.Show();
        }
        private void fillpharmacies(ArrayList pharmacy)
        {
            int i = 0;
            foreach (string s in pharmacy)
            {
                pharmacyListBox.Items.Add(s);
                i++;
            }
        }
		private void backFromCreateAppointmentButton_Click(object sender, EventArgs e)
		{
			createAppointmentPanel.Hide();
			basicPatientInfoPanel.Show();
		}

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

        private void backToBasicPatientInfoPanel_Click(object sender, EventArgs e)
        {
            createPrescriptionPanel.Hide();
            basicPatientInfoPanel.Show();
        }

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

        private void patientSearchTextBox_Click(object sender, EventArgs e)
        {
            patientSearchTextBox.Text = "";
        }

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
                    if (string.IsNullOrEmpty(medName1.Text) || (int)numericUpDownRefills.Value == 0)
                    {
                        new AlertDialog("You're missing some information. Please be sure to fill out all forms throughout.").ShowDialog();
                    } else {
                        medicine1.Name = medName1.Text;
                        medicine1.Route = routeText1.Text;
                        medicine1.Quantity = (int)amntUpDown1.Value;
                        medicine1.Instructions = instructionText1.Text;
                        medicine1.Dosage = dosageTextbox1.Text;
                        medicines.Add(medicine1);
                        
                        Medicine.createMedicine(medicines ,Prescription.createPrescription((int)Doctor.PharmaciesId[pharmacyListBox.SelectedIndex], (int)numericUpDownRefills.Value, selectedPatient.Id));
                        new AlertDialog("Your prescription has been made.").ShowDialog();
                    }
                    break;
                case 2:
                    if (string.IsNullOrEmpty(medName1.Text) || string.IsNullOrEmpty(medName2.Text) || (int)numericUpDownRefills.Value == 0)
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
                    if (string.IsNullOrEmpty(medName1.Text) || string.IsNullOrEmpty(medName2.Text) || string.IsNullOrEmpty(medName3.Text) || (int)numericUpDownRefills.Value == 0)
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
                    if (string.IsNullOrEmpty(medName1.Text) || string.IsNullOrEmpty(medName2.Text) || string.IsNullOrEmpty(medName3.Text) || string.IsNullOrEmpty(medName4.Text) || (int)numericUpDownRefills.Value == 0)
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
                    new AlertDialog("You must add atleast one medicine to create a prescription.").ShowDialog();
                    break;
            }
            
        }
    }
}

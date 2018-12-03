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

		public PatientSearch()
        {
            InitializeComponent();
        }

        private void PatientSearch_Load(object sender, EventArgs e)
        {

        }

        private void viewPatientInformation_Click(object sender, EventArgs e)
        {
			if (patientView.SelectedIndices.Count != 0)
			{
				basicPatientInfoPanel.Show();
				patientSearchPanel.Hide();

				selectedPatient = (Patient)(patientResultsList[patientView.SelectedItems[0].Index]);
				displayPatientInfo(selectedPatient);
				determineDoctorAccess(selectedPatient);
			}
        }

		public void resetPatientSearch()
		{
			patientView.Items.Clear();
			patientSearchTextBox.Text = "";
			patientSearchPanel.Show();
			panel1.Hide();
			updateRecordPanel.Hide();
			viewMedicalRecordPanel.Hide();
		}

        private void nameSearch_Click(object sender, EventArgs e)
        {
			patientView.Items.Clear();
			Patient.retrievePatients(patientSearchTextBox.Text);
			patientResultsList = Patient.displayPatients();
			int i = 0;
			foreach (Patient patient in patientResultsList)
			{
				
				patientView.Items.Add(patient.Name);
				patientView.Items[i].SubItems.Add(patient.Id.ToString());
				patientView.Items[i].SubItems.Add(patient.BirthDate);
				i++;
			}
        }

		private void displayPatientInfo(Patient selectedPatient)
		{
			patientNameLabel.Text = selectedPatient.Name;
			patientIDLabel.Text = selectedPatient.Id.ToString();
			patientDOBLabel.Text = selectedPatient.BirthDate;
			
		}

		private void determineDoctorAccess(Patient selectedPatient)
		{
            // TODO fix button overlap for multiple buttons

			bool hasAccess = selectedPatient.validateAccess(User.Id);
			bool hasRecord = selectedPatient.hasMedicalRecord();
			Console.WriteLine("hasRecord is " + hasRecord);
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
			viewMedicalRecordPanel.Show();
			panel1.Hide();
			selectedPatient.retrieveMedicalRecord();
			selectedPatient.retrieveMedicineHistory();
			displayMedicalRecord();
			displayMedicineHistory();
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

		private void createMedicalRecordButton_Click(object sender, EventArgs e)
		{
            updateOrCreateLabel.Text = "Create Medical Record";
            updateMedicalRecordButton.Hide();
            createMedicalRecordButton.Show();
            updateRecordPanel.Show();
			basicPatientInfoPanel.Hide();
		}

		private void createButton_Click(object sender, EventArgs e)
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

        private void createAppointmentButton_Click(object sender, EventArgs e)
        {
			doctorUser.Id = User.Id;
			doctorUser.retrieveSchedule();

			createAppointmentPanel.Show();
			basicPatientInfoPanel.Hide();
		}

        private void createPrescriptionButton_Click(object sender, EventArgs e)
        {

        }

		private void backFromCreateAppointmentButton_Click(object sender, EventArgs e)
		{
			createAppointmentPanel.Hide();
			basicPatientInfoPanel.Show();
		}

		private void confirmAppointmentButton_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = new ConfirmationPopup("Are you sure you want to make this appointment?",
			   "Appointment with " + selectedPatient.Name + " at " + availableAppointmentsListBox.SelectedItem + " on " + appointmentDateTimePicker.Text).ShowDialog();
			if (dialogResult == DialogResult.OK)
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
			Notice.sendNotice(selectedPatient.Id, message, 12);
		}

		private void appointmentDateTimePicker_ValueChanged(object sender, EventArgs e)
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
    }
}

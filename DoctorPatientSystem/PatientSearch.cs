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
			basicPatientInfoPanel.Hide();
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
			bool hasAccess = selectedPatient.validateAccess(User.Id);
			bool hasRecord = selectedPatient.hasMedicalRecord();
			Console.WriteLine("hasRecord is " + hasRecord);
			if (hasAccess && hasRecord)
			{
				viewMedicalHistoryButton.Show();
				requestMedicalHistoryButton.Hide();
				createMedicalRecordButton.Hide();
			}
			else if (hasAccess && !hasRecord)
			{
				createMedicalRecordButton.Show();
				requestMedicalHistoryButton.Hide();
				viewMedicalHistoryButton.Hide();
			}
			else
			{
				requestMedicalHistoryButton.Show();
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
			basicPatientInfoPanel.Hide();
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
			updateRecordPanel.Show();
			basicPatientInfoPanel.Hide();
			updateOrCreateLabel.Text = "Create Medical Record";
			updateMedicalRecordButton.Hide();
			createMedicalRecordButton.Show();
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
	}
}

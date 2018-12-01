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
			/*
            patientView.Items.Add("Ethen");
            patientView.Items[0].SubItems.Add("Holzapfel");
            patientView.Items[0].SubItems.Add("0000001");
            patientView.Items[0].SubItems.Add("04-02-1998");
			*/
        }

        private void viewPatientInformation_Click(object sender, EventArgs e)
        {
			//new GeneralPatientRecords().Show();
			if (patientView.SelectedIndices.Count != 0)
			{
				basicPatientInfoPanel.Show();
				patientSearchPanel.Hide();

				selectedPatient = (Patient)(patientResultsList[patientView.SelectedItems[0].Index]);
				displayPatientInfo(selectedPatient);
				determineDoctorAccess(selectedPatient);
			}
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
			Console.WriteLine("hasAccess is " + hasAccess);
			if (hasAccess)
			{
				viewMedicalHistoryButton.Show();
				requestMedicalHistoryButton.Hide();
			}
			else
			{
				requestMedicalHistoryButton.Show();
				viewMedicalHistoryButton.Hide();
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
			displayMedicalRecord(selectedPatient);
			displayMedicineHistory(selectedPatient);
		}

		private void displayMedicalRecord(Patient selectedPatient)
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

		private void displayMedicineHistory(Patient selectedPatient)
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

		}

		private void backToBasicInfoButton_Click(object sender, EventArgs e)
		{
			basicPatientInfoPanel.Show();
			viewMedicalRecordPanel.Hide();
		}
	}
}

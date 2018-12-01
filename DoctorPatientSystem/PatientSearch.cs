using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorPatientSystem
{
    public partial class PatientSearch : UserControl
    {
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
            new GeneralPatientRecords().Show();
        }

        private void nameSearch_Click(object sender, EventArgs e)
        {
			patientView.Items.Clear();
			Patient.retrievePatients(patientSearchTextBox.Text);
			int i = 0;
			foreach (Patient patient in Patient.displayPatients())
			{
				
				patientView.Items.Add(patient.Name);
				patientView.Items[i].SubItems.Add(patient.Id.ToString());
				patientView.Items[i].SubItems.Add(patient.BirthDate);
				i++;
			}
        }
    }
}

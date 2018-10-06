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
	public partial class DoctorMenu : Form
	{
		public DoctorMenu()
		{
			InitializeComponent();
		}

        private void notificationButton_Click(object sender, EventArgs e)
        {
            new DoctorNotification().Show();
        }

        private void patientSearchButton_Click(object sender, EventArgs e)
        {
            new PatientSearch().Show();
        }

        private void createRecordButton_Click(object sender, EventArgs e)
        {
            new CreateMedicalRecord().Show();
        }
    }
}

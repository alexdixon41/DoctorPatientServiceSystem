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
        private NotificationUserControl notificationControl = new NotificationUserControl();
        private PatientSearch patientSearchControl = new PatientSearch();
        private CreateMedicalRecord createRecordControl = new CreateMedicalRecord();

		public DoctorMenu()
		{
			InitializeComponent();
		}

        private void notificationButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Hide();
            }
            splitContainer1.Panel2.Controls.Add(notificationControl);
            notificationControl.Dock = DockStyle.Fill;
            notificationControl.Show();
        }

        private void patientSearchButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Hide();
            }
            splitContainer1.Panel2.Controls.Add(patientSearchControl);
            patientSearchControl.Dock = DockStyle.Fill;
            patientSearchControl.Show();
        }

        private void createRecordButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Hide();
            }
            splitContainer1.Panel2.Controls.Add(createRecordControl);
            createRecordControl.Dock = DockStyle.Fill;
            createRecordControl.Show();
        }
    }
}

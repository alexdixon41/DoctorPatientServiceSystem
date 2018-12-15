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
    public partial class PatientMenu : Form
    {
        private NotificationUserControl notificationControl = new NotificationUserControl();
        private AppointmentRequest appointmentRequestControl = new AppointmentRequest();
        private CallRequest callRequestControl = new CallRequest();
        private RefillRequestUserControl refillRequestControl = new RefillRequestUserControl();
        private CheckPatientRecords patientRecordControl = new CheckPatientRecords();

        public PatientMenu()
        {
            InitializeComponent();
        }

		//displays the appointment request usercontrol
        private void button1_Click(object sender, EventArgs e)
        {
            showUnread();
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Hide();
            }
            splitContainer1.Panel2.Controls.Add(appointmentRequestControl);
            appointmentRequestControl.Dock = DockStyle.Fill;
            appointmentRequestControl.Show();
        }

		//displays the call request usercontrol
        private void button2_Click(object sender, EventArgs e)
        {
            showUnread();
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Hide();
            }
            splitContainer1.Panel2.Controls.Add(callRequestControl);
            callRequestControl.Dock = DockStyle.Fill;
            callRequestControl.Show();
        }

		//displays teh refill request usercontrol
        private void button3_Click(object sender, EventArgs e)
        {
            showUnread();
            Prescription.retrievePatientPrescriptions();
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Hide();
            }
            refillRequestControl.populateMedicineList();
            refillRequestControl.populatePrescriptionList();
            splitContainer1.Panel2.Controls.Add(refillRequestControl);
            refillRequestControl.Dock = DockStyle.Fill;
            refillRequestControl.Show();
        }

		//displays the patient record usercontrol
        private void button4_Click(object sender, EventArgs e)
        {
            showUnread();
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Hide();
            }
            splitContainer1.Panel2.Controls.Add(patientRecordControl);
            patientRecordControl.populateLists();
            patientRecordControl.Dock = DockStyle.Fill;
            patientRecordControl.Show();
        }

		//displays the notification usercontrol
        private void button5_Click(object sender, EventArgs e)
        {
            showUnread();
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Hide();
            }
            splitContainer1.Panel2.Controls.Add(notificationControl);
            notificationControl.populateList();
            notificationControl.Dock = DockStyle.Fill;
            notificationControl.Show();
        }

		//shows how many unread notices the user has
        private void showUnread()
        {
            Notice.retrieveNotices();
            notificationsButton.Text = "Notices  (" + Notice.Unread + ")";
        }

		//restarts the application
        private void logoutButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

		//displays number of unread notices
        private void PatientMenu_Load(object sender, EventArgs e)
        {
            showUnread();
        }
    }
}

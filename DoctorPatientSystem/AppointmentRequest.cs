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
    public partial class AppointmentRequest : Form
    {
        public AppointmentRequest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Example items          
            appointmentListView.Columns.Add("Start Time", 130, HorizontalAlignment.Left);
            appointmentListView.Columns.Add("End Time", 130, HorizontalAlignment.Left);
            appointmentListView.Columns.Add("Available", 130, HorizontalAlignment.Left);
            appointmentListView.Items.Add("09:00 a.m.");
            appointmentListView.Items[0].SubItems.Add("09:30 a.m.");
            appointmentListView.Items[0].SubItems.Add("Yes");

            appointmentListView.Items.Add("09:30 a.m.");
            appointmentListView.Items[1].SubItems.Add("10:00 a.m.");
            appointmentListView.Items[1].SubItems.Add("No");
            appointmentListView.Items[1].ForeColor = Color.LightSlateGray;

            appointmentListView.Items.Add("10:00 a.m.");
            appointmentListView.Items[2].SubItems.Add("10:30 a.m.");
            appointmentListView.Items[2].SubItems.Add("Yes");
            //

            appointmentDetailPanel.Hide();
            availableAppointmentPanel.Show();
        }

        private void selectAppointmentButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = new ConfirmationPopup("Are you sure you want to request this appointment?",
                                                "Appointment with Dr. Doolittle at 09:00 AM October 11, 2018").ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                //TODO set appointment

                //Display confirmation
                new AlertDialog("The appointment was requested.").ShowDialog();
            }
        }
      
        private void appointmentListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // Disable selection of disabled items (ForeColor set to LightSlateGray)
            if (e.Item.ForeColor == Color.LightSlateGray)
            {
                e.Item.Selected = false;
                e.Item.Focused = false;
            }
        }

        private void AppointmentRequest_Load(object sender, EventArgs e)
        {
            doctorListBox.Items.Add("Dr. Doolittle");
            doctorListBox.Items.Add("Dr. Doofenschmirtz");
            doctorListBox.Items.Add("Dr. Generic");
            doctorListBox.Items.Add("Dr. Example");
        }
    }
}

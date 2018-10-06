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
    public partial class PatientNotifications : Form
    {
        public PatientNotifications()
        {
            InitializeComponent();
        }

        private void PatientNotifications_Load(object sender, EventArgs e)
        {
            notificationListView.Columns.Add("Message", 220, HorizontalAlignment.Left);          
            notificationListView.Columns.Add("Sender", 120, HorizontalAlignment.Left);
            notificationListView.Columns.Add("Type", 120, HorizontalAlignment.Left);
            notificationListView.Columns.Add("Time", 130, HorizontalAlignment.Left);

            notificationListView.Items.Add("Dr. Doolittle would like to view your medical records.");
            notificationListView.Items[0].SubItems.Add("Dr. Doolittle");
            notificationListView.Items[0].SubItems.Add("Records Request");            
            notificationListView.Items[0].SubItems.Add("09/18/2018 10:00 AM");
            notificationListView.Items.Add("Your refill request has been approved.");
            notificationListView.Items[1].SubItems.Add("Dr. Doofenschmirtz");
            notificationListView.Items[1].SubItems.Add("Refill Request");            
            notificationListView.Items[1].SubItems.Add("06/04/2018 02:00 PM");
        }

        private void selectNotificationButton_Click(object sender, EventArgs e)
        {
            notificationListPanel.Hide();
            notificationDetailPanel.Show();            
            if (notificationListView.SelectedItems[0].SubItems[2].Text.Equals("Records Request")) 
            {
                normalButtonPanel.Hide();           
                recordRequestButtonPanel.Show();
            }
            else
            {
                recordRequestButtonPanel.Hide();
                normalButtonPanel.Show();
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            notificationDetailPanel.Hide();
            notificationListPanel.Show();
        }

        private void denyRecordRequestButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = new ConfirmationPopup("Are you sure you want to deny this record request?", "").ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                //TODO deny the record request

                //after denying a request, return to notifications
                notificationDetailPanel.Hide();
                notificationListPanel.Show();
            }                        
        }

        private void acceptRecordRequestButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = new ConfirmationPopup("Are you sure you want to accept this record request?", "").ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                //TODO accept the record request

                //after accepting a request, return to notifications
                notificationDetailPanel.Hide();
                notificationListPanel.Show();
            }
        }
    }
}

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
    public partial class NotificationUserControl : UserControl
    {
        public NotificationUserControl()
        {
            InitializeComponent();
        }

        public void populateList()
        {
            noticesListView.Items.Clear();
            int i = 0;
            foreach (Notice notice in Notice.displayNotices())
            {
                noticesListView.Items.Add(notice.Type);
                noticesListView.Items[i].SubItems.Add(notice.SentDate);
                noticesListView.Items[i].SubItems.Add(notice.Status);
                noticesListView.Items[i].SubItems.Add(notice.Sender);
                noticesListView.Items[i].SubItems.Add(notice.Message);
                i++;
            }
        }

        private void PatientNotifications_Load(object sender, EventArgs e)
        {
            if (User.Type == User.PATIENT_USER_TYPE)
            {
                Notice.retrieveNotices();
            }
            else
            {

            }
        }

        private void selectNotificationButton_Click(object sender, EventArgs e)
        {
            if (!(noticesListView.SelectedIndices.Count == 0))
            {
                notificationListPanel.Hide();
                notificationDetailPanel.Show();
                if (noticesListView.SelectedItems[0].SubItems[2].Text.Equals("Records Request"))
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

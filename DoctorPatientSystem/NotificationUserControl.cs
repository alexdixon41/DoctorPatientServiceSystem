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

        private Notice selectedNotice;

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

        private void selectNotificationButton_Click(object sender, EventArgs e)
        {
            if (!(noticesListView.SelectedIndices.Count == 0))
            {
                selectedNotice = (Notice)Notice.displayNotices()[noticesListView.SelectedIndices[0]];
                typeTextBox.Text = selectedNotice.Type;
                dateTextBox.Text = selectedNotice.SentDate;
                fromTextBox.Text = selectedNotice.Sender;
                messageTextBox.Text = selectedNotice.Message;
                notificationListPanel.Hide();
                noticeDetailPanel.Show();
                selectedNotice.updateStatus();

                if (selectedNotice.Type.Equals("Record Request"))
                {
                    denyButton.Show();
                    acceptButton.Show();
                }
                else
                {
                    denyButton.Hide();
                    acceptButton.Hide();
                }
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            noticeDetailPanel.Hide();
            notificationListPanel.Show();
        }

        private void denyRecordRequestButton_Click(object sender, EventArgs e)
        {
			//NEED TO CHECK IF THIS BUTTON IS STILL BEING USED

            DialogResult dialogResult = new DialogResult();
            dialogResult = new ConfirmationPopup("Are you sure you want to deny this record request?", "").ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
				//TODO deny the record request
				String message = Patient.retrievePatientByID(User.Id).Name + " has denied your request to view their medical records.";
				int receiverID = Notice.retrievedDoctorSenderID(selectedNotice.Id);
				Console.WriteLine("receiverID is "+receiverID);
				
                //after denying a request, return to notifications
                noticeDetailPanel.Hide();
                notificationListPanel.Show();
            }                        
        }

        private void acceptRecordRequestButton_Click(object sender, EventArgs e)
        {
			//NEED TO CHECK IF THIS BUTTON IS STILL BEING USED

            DialogResult dialogResult = new DialogResult();
            dialogResult = new ConfirmationPopup("Are you sure you want to accept this record request?", "").ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                //TODO accept the record request

                //after accepting a request, return to notifications
                noticeDetailPanel.Hide();
                notificationListPanel.Show();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Notice.retrieveNotices();
            populateList();
            noticeDetailPanel.Hide();
            notificationListPanel.Show();
        }

		private void denyButton_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = new DialogResult();
			dialogResult = new ConfirmationPopup("Are you sure you want to deny this record request?", "").ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				//TODO deny the record request
				String message = Patient.retrievePatientByID(User.Id).Name + " has denied your request to view their medical records.";
				int receiverID = Notice.retrievedDoctorSenderID(selectedNotice.Id);
				Notice.sendNotice(receiverID, message, 9);

				//after denying a request, return to notifications
				noticeDetailPanel.Hide();
				notificationListPanel.Show();
			}
		}

		private void acceptButton_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = new DialogResult();
			dialogResult = new ConfirmationPopup("Are you sure you want to accept this record request?", "").ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				//TODO accept the record request
				int doctorID = Notice.retrievedDoctorSenderID(selectedNotice.Id);
				String message = Patient.retrievePatientByID(User.Id).Name + " has accepted your request to view their medical records.";
				Notice.sendNotice(doctorID, message, 8);
				Doctor.grantRecordAccess(doctorID, User.Id);

				//after accepting a request, return to notifications
				noticeDetailPanel.Hide();
				notificationListPanel.Show();
			}
		}
	}
}

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

		//displays the user's notices in the listview
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

		//displays the details of the selected notice and updates the status of the notice to received
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
                    buttonPanel.Show();
                }
                else
                {
                    buttonPanel.Hide();
                }
            }
        }

		//returns to the notification list panel
        private void confirmButton_Click(object sender, EventArgs e)
        {
            noticeDetailPanel.Hide();
            notificationListPanel.Show();
        }            

		//returns to the notificaitons list panel and refreshed the list
        private void backButton_Click(object sender, EventArgs e)
        {
            Notice.retrieveNotices();
            populateList();
            noticeDetailPanel.Hide();
            notificationListPanel.Show();
        }

		//Sends a record request denied notice to the doctor
		private void denyButton_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = new DialogResult();
			dialogResult = new ConfirmationPopup("Are you sure you want to deny this record request?", "").ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				//deny the record request
				String message = Patient.retrievePatientByID(User.Id).Name + " has denied your request to view their medical records.";
				int receiverID = Notice.retrievedDoctorSenderID(selectedNotice.Id);
				Notice.sendNotice(receiverID, message, Notice.SEND_RECORD_REQUEST_REJECT_NOTICE_TYPE);

				//after denying a request, return to notifications
				Notice.retrieveNotices();
				populateList();
				noticeDetailPanel.Hide();
				notificationListPanel.Show();
			}
		}

		//Sends a record request accepted notice to the doctor and grants the doctor access to the patient's records
		private void acceptButton_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = new DialogResult();
			dialogResult = new ConfirmationPopup("Are you sure you want to accept this record request?", "").ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				//accept the record request
				int doctorID = Notice.retrievedDoctorSenderID(selectedNotice.Id);
				String message = Patient.retrievePatientByID(User.Id).Name + " has accepted your request to view their medical records.";
				Notice.sendNotice(doctorID, message, Notice.SEND_RECORD_REQUEST_ACCEPT_NOTICE_TYPE);
				Doctor.grantRecordAccess(doctorID, User.Id);

				//after accepting a request, return to notifications
				Notice.retrieveNotices();
				populateList();
				noticeDetailPanel.Hide();
				notificationListPanel.Show();
			}
		}

    }
}

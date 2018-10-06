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
	public partial class DoctorNotification : Form
	{
		public DoctorNotification()
		{
			InitializeComponent();
		}

		private void DoctorNotification_Load(object sender, EventArgs e)
		{
			
			doctorNotificationListView.Columns.Add("Message", 200, HorizontalAlignment.Left);
			doctorNotificationListView.Columns.Add("Sender", 120, HorizontalAlignment.Left);
			doctorNotificationListView.Columns.Add("Type", 120, HorizontalAlignment.Left);
			doctorNotificationListView.Columns.Add("Time", 140, HorizontalAlignment.Left);

			doctorNotificationListView.Items.Add("Bob Smith wants a refill on his prescription.");
			doctorNotificationListView.Items[0].SubItems.Add("Bob Smith");
			doctorNotificationListView.Items[0].SubItems.Add("Refill Request");
			doctorNotificationListView.Items[0].SubItems.Add("10/05/2018 12:04 p.m.");

			doctorNotificationListView.Items.Add("Jenny Johnson is requesting a phone call.");
			doctorNotificationListView.Items[1].SubItems.Add("Jenny Johnson");
			doctorNotificationListView.Items[1].SubItems.Add("Phone Call Request");
			doctorNotificationListView.Items[1].SubItems.Add("10/05/2018 09:45 a.m.");

			doctorNotificationListView.Items.Add("Sarah Jones wants a refill on her prescription.");
			doctorNotificationListView.Items[2].SubItems.Add("Sarah Jones");
			doctorNotificationListView.Items[2].SubItems.Add("Refill Request");
			doctorNotificationListView.Items[2].SubItems.Add("10/04/2018 11:23 a.m.");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			new RefillRequestResponse().Show();
			//new PhoneRequestResponse().Show();
		}
	}
}

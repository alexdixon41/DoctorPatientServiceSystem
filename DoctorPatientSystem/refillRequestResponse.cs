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
	public partial class RefillRequestResponse : Form
	{
		public RefillRequestResponse()
		{
			InitializeComponent();
		}

		private void refillRequestResponse_Load(object sender, EventArgs e)
		{
			prescriptionDetailsListView.Items.Add("Patient: Bob Smith");
			prescriptionDetailsListView.Items.Add("Birthday: 01/01/1980");
			prescriptionDetailsListView.Items.Add("RX#: 123456");
			prescriptionDetailsListView.Items.Add("Medicine: Tamiflu");
			prescriptionDetailsListView.Items.Add("Dosage: 1 pill a day");
			prescriptionDetailsListView.Items.Add("Doctor: Dr. Doolittle");
			prescriptionDetailsListView.Items.Add("Refills remaining: 0");

			messageTextBox.Text = "Bob Smith wants a refill on his prescription.";
		}

		private void acceptButton_Click(object sender, EventArgs e)
		{
			new RefillRequestResponsePopup().Show();
		}
	}
}

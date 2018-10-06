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
	public partial class PhoneRequestResponse : Form
	{
		public PhoneRequestResponse()
		{
			InitializeComponent();
		}

		private void PhoneRequestResponse_Load(object sender, EventArgs e)
		{
			messageTextBox.Text = "Jenny Johnson is requesting a phone call.";
		}

		private void acceptButton_Click(object sender, EventArgs e)
		{
			new PhoneRequestResponsePopup().Show();
		}
	}
}

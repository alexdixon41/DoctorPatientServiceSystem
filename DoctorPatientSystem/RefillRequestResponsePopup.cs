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
	public partial class RefillRequestResponsePopup : Form
	{
		public RefillRequestResponsePopup()
		{
			InitializeComponent();
		}

		private void confirmButton_Click(object sender, EventArgs e)
		{
			new AlertDialog("The refill request was accepted.").ShowDialog();
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}

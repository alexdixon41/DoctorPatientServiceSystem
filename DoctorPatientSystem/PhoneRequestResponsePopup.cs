﻿using System;
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
	public partial class PhoneRequestResponsePopup : Form
	{
		public PhoneRequestResponsePopup()
		{
			InitializeComponent();
		}

		private void confirmButton_Click(object sender, EventArgs e)
		{
			new AlertDialog("The phone call request was accepted.").ShowDialog();
			this.Close();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

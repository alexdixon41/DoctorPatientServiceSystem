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
	public partial class CreateMedicalRecord : UserControl
	{
		public CreateMedicalRecord()
		{
			InitializeComponent();
		}

		private void submitButton_Click(object sender, EventArgs e)
		{
			new AlertDialog("The medical request was created successfully").ShowDialog();			
		}
    }
}

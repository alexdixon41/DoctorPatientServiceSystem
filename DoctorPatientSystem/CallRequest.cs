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
    public partial class CallRequest : Form
    {
        public CallRequest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (doctorListBox.SelectedItem != null)
            {                
                new AlertDialog(doctorListBox.SelectedItem.ToString() + " will contact you soon.").ShowDialog();
            }            
        }

        private void CallRequest_Load(object sender, EventArgs e)
        {
            // Example listbox items
            doctorListBox.Items.Add("Dr. Doolittle");
            doctorListBox.Items.Add("Dr. Doofenschmirtz");
            doctorListBox.Items.Add("Dr. Generic");
            doctorListBox.Items.Add("Dr. Example");
            //
        }
    }
}

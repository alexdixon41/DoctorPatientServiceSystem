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
    public partial class CallRequest : UserControl
    {
        private string key = "";
        public CallRequest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO create phone call request           
        }

        private void CallRequest_Load(object sender, EventArgs e)
        {
            Doctor.retrieveDoctors(key);
            Doctor.displayDoctors();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            key = searchKey.Text;
            if (!searchKey.Text.Equals(null))
            {
                Doctor.retrieveDoctors(key);
                Doctor.displayDoctors();
            }else
            {
                Doctor.displayDoctors();
            }
        }

        private void doctorListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

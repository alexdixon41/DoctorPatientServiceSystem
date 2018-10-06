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
    public partial class PatientMenu : Form
    {
        public PatientMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AppointmentRequest().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new CallRequest().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new RefillRequest().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new CheckPatientRecords().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new PatientNotifications().Show();
        }
    }
}

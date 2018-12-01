using MySql.Data.MySqlClient;
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
    public partial class AppointmentRequest : UserControl
    {
        public AppointmentRequest()
        {
            InitializeComponent();
        }

        public void populateList()
        {
            doctorListView.Items.Clear();
            int i = 0;
            foreach (Doctor doc in Doctor.displayDoctors())
            {
                doctorListView.Items.Add(doc.Name);
                doctorListView.Items[i].SubItems.Add(doc.OfficeName);
                doctorListView.Items[i].SubItems.Add(doc.OfficeNumber);
                i++;
            }
        }

        private void selectAppointmentButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = new ConfirmationPopup("Are you sure you want to request this appointment?",
                                                "Appointment with Dr. Doolittle at 09:00 AM October 11, 2018").ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                //TODO set appointment

                //Display confirmation
                new AlertDialog("The appointment was requested.").ShowDialog();
            }
        }        
        
        private void viewAppointmentsButton_Click(object sender, EventArgs e)
        {
            if (!(doctorListView.SelectedIndices.Count == 0))
            {
                Doctor selectedDoctor = (Doctor)Doctor.displayDoctors()[doctorListView.SelectedIndices[0]];
                dateLabel.Text = dateTimePicker1.Text;
                selectedDoctor.retrieveAppointments(dateTimePicker1.Value.Date.ToShortDateString());
                foreach (string s in selectedDoctor.Appointments)
                    Console.WriteLine(s);
                foreach (string s in Doctor.appointmentTimes)
                {                    
                    if (!(selectedDoctor.Appointments.Contains(s))) {
                        appointmentListView.Items.Add(s);
                    }
                }
                appointmentDetailPanel.Hide();
                availableAppointmentPanel.Show();
            }            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("Search for a doctor"))
            {
                textBox1.Text = "";
            }
            Doctor.retrieveDoctors(textBox1.Text);
            Doctor.getAvailableDoctors(dateTimePicker1.Value.DayOfWeek);
            populateList();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            availableAppointmentPanel.Hide();
            appointmentDetailPanel.Show();
        }
    }
}

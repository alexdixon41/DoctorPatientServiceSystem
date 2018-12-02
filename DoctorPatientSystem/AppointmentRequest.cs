using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
        private Doctor selectedDoctor;
        private ArrayList appointmentTimes = new ArrayList();

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
            DialogResult dialogResult = new ConfirmationPopup("Are you sure you want to request this appointment?",
                "Appointment with " + selectedDoctor.Name + " at " + listBox1.SelectedItem + " on " + dateLabel.Text).ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                //Create new appointment
                DateTime date = Convert.ToDateTime(dateLabel.Text);
                DateTime time = Convert.ToDateTime(listBox1.SelectedItem);
                date = date.AddHours(time.Hour);
                date = date.AddMinutes(time.Minute);
                Appointment.createAppointment(selectedDoctor.Id, User.Id, date.ToString("yyyy-MM-dd HH:mm:ss"), "New");

                //Display confirmation
                new AlertDialog("The appointment was requested.").ShowDialog();
            }
        }        
        
        private void viewAppointmentsButton_Click(object sender, EventArgs e)
        {
            if (!(doctorListView.SelectedIndices.Count == 0))
            {
                listBox1.Items.Clear();
                appointmentTimes.Clear();
                selectedDoctor = (Doctor)Doctor.displayDoctors()[doctorListView.SelectedIndices[0]];
                dateLabel.Text = dateTimePicker1.Text;
                selectedDoctor.retrieveAppointments(dateTimePicker1.Value.ToString("yyyy-MM-dd"));               
                foreach (string s in Doctor.appointmentTimes)
                {
                    appointmentTimes.Add(s);
                }
                foreach (string s in Doctor.appointmentTimes)
                {
                    foreach(Appointment apt in selectedDoctor.Appointments)
                    {
                        if (apt.StartTime.Equals(s))
                            appointmentTimes.Remove(s);
                    }
                }
                foreach (string s in appointmentTimes)
                {
                    DateTime d = Convert.ToDateTime(s);
                    listBox1.Items.Add(d.ToShortTimeString());
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("Search for a doctor"))
            {
                Doctor.retrieveDoctors(textBox1.Text);
                Doctor.getAvailableDoctors(dateTimePicker1.Value.DayOfWeek);
                populateList();
            }
        }
    }
}

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
                doctorListView.Items[i].SubItems.Add(doc.OfficePhone);
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
      
        private void appointmentListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // Disable selection of disabled items (ForeColor set to LightSlateGray)
            if (e.Item.ForeColor == Color.LightSlateGray)
            {
                e.Item.Selected = false;
                e.Item.Focused = false;
            }
        }

        
        private void AppointmentRequest_Load(object sender, EventArgs e)
        {
/*            doctorListView.Items.Clear();
            Doctor.retrieveDoctors("");
            foreach (Doctor doc in Doctor.displayDoctors())
            {
                doctorListView.Items.Add(doc.Name);                
            }
            SelectionRange selectionRange = appointmentCalendar.GetDisplayRange(true);
            DateTime day = selectionRange.Start;
            visibleMonth = day.Month;
            while (day.CompareTo(selectionRange.End) <= 0)
            {
                if (doctorListView.SelectedIndices.IndexOf(0) >= 0 && Doctor.displayDoctors()[doctorListView.SelectedIndices.IndexOf(0)].WorkDays.Contains(day.DayOfWeek))
                {
                    appointmentCalendar.AddBoldedDate(day);                    
                }
                day = day.AddDays(1);
            }        
            appointmentCalendar.UpdateBoldedDates();
            */
        }
        /*


        private void doctorListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            appointmentCalendar.RemoveAllBoldedDates();
            SelectionRange selectionRange = appointmentCalendar.GetDisplayRange(true);
            DateTime day = selectionRange.Start;
            while(day.CompareTo(selectionRange.End) <= 0)
            {
                if (Doctor.displayDoctors()[doctorListView.SelectedIndices.IndexOf(0)].WorkDays.Contains(day.DayOfWeek))
                {
                    appointmentCalendar.AddBoldedDate(day);
                }                
                day = day.AddDays(1);
            }
            appointmentCalendar.UpdateBoldedDates();            
        }*/

        private void viewAppointmentsButton_Click(object sender, EventArgs e)
        {/*
            if (Doctor.displayDoctors()[doctorListView.SelectedIndices.IndexOf(0)].WorkDays.Contains(appointmentCalendar.SelectionStart.DayOfWeek))
            {
                new AlertDialog("" + Doctor.displayDoctors()[doctorListView.SelectedIndices.IndexOf(0)].Name + " is not available on this day. "
                    + "Please select a bolded date from the calendar");
            }

            appointmentDetailPanel.Hide();
            availableAppointmentPanel.Show();*/
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void appointmentCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

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
            populateList();
        }
    }
}

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

        private int visibleMonth = 0;

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
            doctorListBox.Items.Clear();
            Doctor.retrieveDoctors();
            foreach (Doctor doc in Doctor.displayDoctors())
            {
                doctorListBox.Items.Add(doc.Name);                
                Console.WriteLine(doc);
            }
            SelectionRange selectionRange = appointmentCalendar.GetDisplayRange(true);
            DateTime day = selectionRange.Start;
            visibleMonth = day.Month;
            while (day.CompareTo(selectionRange.End) <= 0)
            {
                if (doctorListBox.SelectedIndex >= 0 && Doctor.displayDoctors()[doctorListBox.SelectedIndex].WorkDays.Contains(day.DayOfWeek))
                {
                    appointmentCalendar.AddBoldedDate(day);                    
                }
                day = day.AddDays(1);
            }        
            appointmentCalendar.UpdateBoldedDates();
        }

        private void appointmentCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (appointmentCalendar.SelectionStart.Month != visibleMonth)
            {
                SelectionRange selectionRange = appointmentCalendar.GetDisplayRange(true);
                DateTime day = selectionRange.Start;
                visibleMonth = day.Month;
                while (day.CompareTo(selectionRange.End) <= 0)
                {
                    if (doctorListBox.SelectedIndex >= 0 && Doctor.displayDoctors()[doctorListBox.SelectedIndex].WorkDays.Contains(day.DayOfWeek))
                    {
                        appointmentCalendar.AddBoldedDate(day);
                    }
                    day = day.AddDays(1);
                }
                appointmentCalendar.UpdateBoldedDates();
            }
        }

        private void doctorListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            appointmentCalendar.RemoveAllBoldedDates();
            SelectionRange selectionRange = appointmentCalendar.GetDisplayRange(true);
            DateTime day = selectionRange.Start;
            while(day.CompareTo(selectionRange.End) <= 0)
            {
                if (Doctor.displayDoctors()[doctorListBox.SelectedIndex].WorkDays.Contains(day.DayOfWeek))
                {
                    appointmentCalendar.AddBoldedDate(day);
                }                
                day = day.AddDays(1);
            }
            appointmentCalendar.UpdateBoldedDates();            
        }

        private void viewAppointmentsButton_Click(object sender, EventArgs e)
        {
            if (Doctor.displayDoctors()[doctorListBox.SelectedIndex].WorkDays.Contains(appointmentCalendar.SelectionStart.DayOfWeek))
            {
                new AlertDialog("" + Doctor.displayDoctors()[doctorListBox.SelectedIndex].Name + " is not available on this day. "
                    + "Please select a bolded date from the calendar");
            }

            appointmentDetailPanel.Hide();
            availableAppointmentPanel.Show();
        }
    }
}

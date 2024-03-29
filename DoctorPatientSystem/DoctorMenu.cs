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
	public partial class DoctorMenu : Form
	{
        private NotificationUserControl notificationControl = new NotificationUserControl();
        private RefillUserControl refillRequestControl = new RefillUserControl();
        private PatientSearch patientSearchControl = new PatientSearch();
		private ViewAppointments viewAppointmentsControl = new ViewAppointments();

		public DoctorMenu()
		{
			InitializeComponent();
		}

		//displays the notification usercontrol
        private void notificationButton_Click(object sender, EventArgs e)
        {
            showUnread();
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Hide();
            }
            splitContainer1.Panel2.Controls.Add(notificationControl);
            notificationControl.populateList();
            notificationControl.Dock = DockStyle.Fill;
            notificationControl.Show();
        }

		//displays the patient search usercontrol
        private void patientSearchButton_Click(object sender, EventArgs e)
        {
            showUnread();
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Hide();
            }
            splitContainer1.Panel2.Controls.Add(patientSearchControl);
			patientSearchControl.resetPatientSearch();
            patientSearchControl.Dock = DockStyle.Fill;
            patientSearchControl.Show();
        }

		//displays the view appointments usercontrol
		private void viewAppointmentsButton_Click(object sender, EventArgs e)
		{
            showUnread();
			foreach (Control c in splitContainer1.Panel2.Controls)
			{
				c.Hide();
			}
			splitContainer1.Panel2.Controls.Add(viewAppointmentsControl);
			viewAppointmentsControl.resetViewAppointment();
			viewAppointmentsControl.populateListView();
			viewAppointmentsControl.Dock = DockStyle.Fill;
			viewAppointmentsControl.Show();
		}

		//displays the refill request usercontrol
        private void refillRequestButton_Click(object sender, EventArgs e)
        {            
            showUnread();
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Hide();
            }
            splitContainer1.Panel2.Controls.Add(refillRequestControl);
            refillRequestControl.populateList();
            refillRequestControl.Dock = DockStyle.Fill;
            refillRequestControl.Show();
        }

		//displays how many unread notifications there are
        private void showUnread()
        {
            Notice.retrieveNotices();
            RefillRequest.retrieveRefillRequests();
            Appointment.retrieveAppointments(User.Id);
            notificationButton.Text = "Notices  (" + Notice.Unread + ")";
            refillRequestButton.Text = "Refill Requests  (" + RefillRequest.NewRefillRequestCount + ")";
            viewAppointmentsButton.Text = "Appointments  (" + Appointment.NewAppointmentCount + ")";
        }

		//restarts the application
        private void doctorLogoutButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

		//shows number of unread notifications
        private void DoctorMenu_Load(object sender, EventArgs e)
        {
            showUnread();
        }
    }
}

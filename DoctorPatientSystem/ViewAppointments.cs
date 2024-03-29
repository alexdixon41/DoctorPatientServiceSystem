﻿using System;
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
	public partial class ViewAppointments : UserControl
	{
        private Appointment selectedAppointment = new Appointment();

		public ViewAppointments()
		{
			InitializeComponent();
		}

		//displays the doctors appointments in the list view 
		public void populateListView()
		{
			appointmentsListView.Items.Clear();
			int i = 0;
			foreach (Appointment appointment in Appointment.displayAppointments())
			{
				appointmentsListView.Items.Add(appointment.PatientName);
				appointmentsListView.Items[i].SubItems.Add(appointment.StartTime);
				appointmentsListView.Items[i].SubItems.Add(appointment.Status);
				i++;
			}
		}

		//returns to the viewAppointmentsPanel
		private void backButton_Click(object sender, EventArgs e)
		{
			viewAppointmentsPanel.Show();
			appointmentDetailPanel.Hide();
		}

		//Denies the appointment and sends notice that appointment was denied
		private void denyButton_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = new DialogResult();
			dialogResult = new ConfirmationPopup("Are you sure you want to deny this appointment request?", "").ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				//update appointment status
				selectedAppointment.updateStatus("Denied");	

				// Send notice to patient that their appointment was denied
				String message = Doctor.retrieveDoctorName(User.Id) + " has denied your appointment request.";
				Notice.sendNotice(Int32.Parse(selectedAppointment.PatientID), message, Notice.SEND_APPOINTMENT_REQUEST_REJECT_NOTICE_TYPE);

				populateListView(); //update list view with changed status
				viewAppointmentsPanel.Show();
				appointmentDetailPanel.Hide();
			}
		}

		//Accepts the appointment and sends notice that the appointment was accepted
		private void acceptButton_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = new DialogResult();
			dialogResult = new ConfirmationPopup("Are you sure you want to accept this appointment request?", "").ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				selectedAppointment.updateStatus("Accepted");

				// Send notice to patient that their appointment was accepted
				String message = Doctor.retrieveDoctorName(User.Id) + " has accepted your appointment request.";
				Notice.sendNotice(Int32.Parse(selectedAppointment.PatientID), message, Notice.SEND_APPOINTMENT_REQUEST_ACCEPT_NOTICE_TYPE);

				populateListView();
				viewAppointmentsPanel.Show();
				appointmentDetailPanel.Hide();
			}
		}

		//reset this UserControl to default state at view appointments panel
		public void resetViewAppointment()
		{
			viewAppointmentsPanel.Show();
			appointmentDetailPanel.Hide();
		}

		//Determines if the accept and deny button are enabled based on the appointments status
        private void appointmentsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(appointmentsListView.SelectedIndices.Count == 0))
            {
                selectedAppointment = (Appointment)(Appointment.displayAppointments()[appointmentsListView.SelectedIndices[0]]);
                if (selectedAppointment.Status.Equals("New"))
                {
                    acceptButton.Enabled = true;
                    denyButton.Enabled = true;
                }
                else
                {
                    acceptButton.Enabled = false;
                    denyButton.Enabled = false;
                }
            }
        }
    }
}

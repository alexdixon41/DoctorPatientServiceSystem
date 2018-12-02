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
	public partial class ViewAppointments : UserControl
	{
		private Appointment selectedAppointment = new Appointment();

		public ViewAppointments()
		{
			InitializeComponent();
		}

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

		private void selectButton_Click(object sender, EventArgs e)
		{
			if (appointmentsListView.SelectedIndices.Count != 0)
			{
				selectedAppointment = (Appointment)(Appointment.displayAppointments()[appointmentsListView.SelectedIndices[0]]);
				viewAppointmentsPanel.Hide();
				appointmentDetailPanel.Show();
				displayAppointmentDetails();
			}
		}

		private void displayAppointmentDetails()
		{
			nameLabel.Text = selectedAppointment.PatientName;
			timeLabel.Text = selectedAppointment.StartTime;
			statusLabel.Text = selectedAppointment.Status;
			if (selectedAppointment.Status.Equals("New"))
			{
				acceptButton.Show();
				denyButton.Show();
			}
			else
			{
				acceptButton.Hide();
				denyButton.Hide();
			}
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			viewAppointmentsPanel.Show();
			appointmentDetailPanel.Hide();
		}

		private void denyButton_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = new DialogResult();
			dialogResult = new ConfirmationPopup("Are you sure you want to deny this appointment request?", "").ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				//update appointment status
				selectedAppointment.UpdateStatus("Denied");	

				// Send notice to patient that their appointment was denied
				String message = Doctor.retrieveDoctorName(User.Id) + " has denied your appointment request.";
				Notice.sendNotice(Int32.Parse(selectedAppointment.PatientID), message, 11);

				populateListView(); //update list view with changed status
				viewAppointmentsPanel.Show();
				appointmentDetailPanel.Hide();
			}
		}

		private void acceptButton_Click(object sender, EventArgs e)
		{
			//TO DO: Change status of appt to accepted and send notice to patient
			DialogResult dialogResult = new DialogResult();
			dialogResult = new ConfirmationPopup("Are you sure you want to accept this appointment request?", "").ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				selectedAppointment.UpdateStatus("Accepted");

				// Send notice to patient that their appointment was accepted
				String message = Doctor.retrieveDoctorName(User.Id) + " has accepted your appointment request.";
				Notice.sendNotice(Int32.Parse(selectedAppointment.PatientID), message, 10);

				populateListView();
				viewAppointmentsPanel.Show();
				appointmentDetailPanel.Hide();
			}
		}
	}
}

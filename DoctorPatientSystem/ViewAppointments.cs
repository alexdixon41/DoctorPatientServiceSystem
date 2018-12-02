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

	}
}

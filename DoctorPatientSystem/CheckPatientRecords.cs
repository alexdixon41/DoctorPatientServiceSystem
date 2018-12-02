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
    public partial class CheckPatientRecords : UserControl
    {
        public CheckPatientRecords()
        {
            InitializeComponent();
        }
        
        public void populateLists()
        {
            Patient patient = Patient.retrievePatientByID(User.Id);
            patient.retrieveMedicalRecord();
            patient.retrieveMedicineHistory();
            generalHistoryListBox.Items.Clear();
            prescriptionHistoryListView.Items.Clear();

            generalHistoryListBox.Items.Clear();
            generalHistoryListBox.Items.Add("Name: " + patient.Name);
            generalHistoryListBox.Items.Add("Date of Birth: " + patient.BirthDate);
            generalHistoryListBox.Items.Add("Height: " + patient.Height);
            generalHistoryListBox.Items.Add("Weight: " + patient.Weight);
            generalHistoryListBox.Items.Add("Body Mass Index: " + patient.BodyMassIndex);

            int i = 0;
            foreach (Medicine m in patient.MedicineHistory)
            {
                prescriptionHistoryListView.Items.Add(m.Date);
                prescriptionHistoryListView.Items[i].SubItems.Add(m.Name);
                prescriptionHistoryListView.Items[i].SubItems.Add("" + m.Quantity);
                prescriptionHistoryListView.Items[i].SubItems.Add("" + m.Dosage);
                prescriptionHistoryListView.Items[i].SubItems.Add(m.Route);
                prescriptionHistoryListView.Items[i].SubItems.Add(m.Instructions);
                i++;
            }
        }
    }
}

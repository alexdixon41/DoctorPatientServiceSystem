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
    /// <summary>
    /// This form allows the patient to request a refill of a past prescription.
    /// </summary>
    public partial class RefillRequest : UserControl
    {
        private Prescription selectedPrescription = new Prescription();
        public RefillRequest()
        {
            InitializeComponent();
        }

        private void RefillRequest_Load(object sender, EventArgs e)
        {
            Prescription.retrievePrescriptions();
            populatePrescriptionList();
        }

        private void selectPrescriptionButton_Click(object sender, EventArgs e)
        {
                
            prescriptionsPanel.Hide();
            prescriptionDetailPanel.Show();
            selectedPrescription.retrieveMedicines(selectedPrescription.Id);
            populateMedicineList();
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            prescriptionDetailPanel.Hide();
            prescriptionsPanel.Show();
        }

        private void prescriptionDetailPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void populateMedicineList()
        {
            prescriptionListView.Items.Clear();
            int i = 0;
            foreach (Medicine medicine in selectedPrescription.Medicines)
            {
                prescriptionListView.Items.Add(medicine.Name);
                prescriptionListView.Items[i].SubItems.Add("" + medicine.Quantity);
                prescriptionListView.Items[i].SubItems.Add(medicine.Dosage);
                prescriptionListView.Items[i].SubItems.Add(medicine.Route);
                prescriptionListView.Items[i].SubItems.Add(medicine.Instructions);
                i++;
            }
        }
        public void populatePrescriptionList()
        {
            prescriptionListView.Items.Clear();
            int i = 0;
            foreach (Prescription prescriptions in Prescription.displayPrescriptions())
            {
                prescriptionListView.Items.Add("" + prescriptions.Id);
                prescriptionListView.Items[i].SubItems.Add(prescriptions.PrescriberName);
                prescriptionListView.Items[i].SubItems.Add(prescriptions.PharmacyName);
                prescriptionListView.Items[i].SubItems.Add(prescriptions.Date);
                i++;
            }
        }
        private void prescriptionListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPrescription = (Prescription)Prescription.displayPrescriptions()[prescriptionListView.SelectedIndices[0]];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*DialogResult dialogResult = new DialogResult();
            dialogResult = new ConfirmationPopup("Are you sure you want to request this refill?", 
                                            "Amoxicillin 50 mg").ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                //TODO request refill
                
                new AlertDialog("The refill was requested.").ShowDialog();
            }
            */
        }
    }
}

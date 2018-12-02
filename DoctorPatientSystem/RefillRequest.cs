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
            selectedPrescription = (Prescription)Prescription.displayPrescriptions()[prescriptionListView.SelectedIndices[0]];
            prescriptionsPanel.Hide();
            prescriptionDetailPanel.Show();
            prescriptionDateLabel.Text = "Date: " + selectedPrescription.Date.ToString();
            prescriptionStatusLabel.Text = "Status: " + selectedPrescription.Status.ToString();
            prescriptionRefillLabel.Text = "Refills: " + selectedPrescription.Refills.ToString();
            prescriptionRemainingRefillsLabel.Text = "Remaining Refills: " + selectedPrescription.RemainingRefills.ToString();
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
            prescriptionDetailListView.Items.Clear();
            int i = 0;
            foreach (Medicine medicine in selectedPrescription.Medicines)
            {
                prescriptionDetailListView.Items.Add(medicine.Name);
                prescriptionDetailListView.Items[i].SubItems.Add("" + medicine.Quantity);
                prescriptionDetailListView.Items[i].SubItems.Add(medicine.Dosage);
                prescriptionDetailListView.Items[i].SubItems.Add(medicine.Route);
                prescriptionDetailListView.Items[i].SubItems.Add(medicine.Instructions);
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
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedPrescription.RemainingRefills == 0) {
                DialogResult dialogResult = new DialogResult();
                dialogResult = new ConfirmationPopup("You have no refills remaining.","Are you sure you want to request a permit for this refill from the doctor?").ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    Notice.sendNotice(selectedPrescription.DoctorId, selectedPrescription.PatientName.ToString() + " would like to request a permit for more refills.", Notice.SEND_REFILL_PERMIT_NOTICE_TYPE);
                    new AlertDialog("The refill was requested.").ShowDialog();
                }
            }else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = new ConfirmationPopup("You have " + selectedPrescription.RemainingRefills.ToString() + " refills remaining.", "Are you sure you want to request a refill from your pharmacy?").ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    selectedPrescription.createRefillRequest(selectedPrescription.PharmacyId);
                    new AlertDialog("The refill was requested.").ShowDialog();
                }
            }
            
        }
    }
}

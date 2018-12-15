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
    public partial class RefillRequestUserControl : UserControl
    {
        private Prescription selectedPrescription = new Prescription();
        public RefillRequestUserControl()
        {
            InitializeComponent();
        }

		//displays the details of the selected prescription
        private void selectPrescriptionButton_Click(object sender, EventArgs e)
        {
            if (!(prescriptionListView.SelectedIndices.Count == 0))
            {
                selectedPrescription = (Prescription)Prescription.displayPrescriptions()[prescriptionListView.SelectedIndices[0]];
                prescriptionsPanel.Hide();
                prescriptionDetailPanel.Show();
                dateLabel.Text = selectedPrescription.Date.ToString();
                statusLabel.Text = selectedPrescription.Status.ToString();
                refillsLabel.Text = selectedPrescription.Refills.ToString();
                remainingLabel.Text = selectedPrescription.RemainingRefills.ToString();
                selectedPrescription.retrieveMedicines();
                populateMedicineList();
            }
        }

		//returs to the prescriptions panel
        private void backButton_Click(object sender, EventArgs e)
        {
            prescriptionDetailPanel.Hide();
            prescriptionsPanel.Show();
        }    

		//Displays the medicines of the selected prescription in the listview
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
		
		//displays the patients prescriptions in the listview
        public void populatePrescriptionList()
        {
            prescriptionListView.Items.Clear();
            int i = 0;
            foreach (Prescription prescription in Prescription.displayPrescriptions())
            {
                prescriptionListView.Items.Add(prescription.Date);
                prescriptionListView.Items[i].SubItems.Add(prescription.Status);
                prescriptionListView.Items[i].SubItems.Add(prescription.PrescriberName);
                prescriptionListView.Items[i].SubItems.Add(prescription.PharmacyName);
                prescriptionListView.Items[i].SubItems.Add("" + prescription.Refills);
                prescriptionListView.Items[i].SubItems.Add("" + prescription.RemainingRefills);
                i++;
            }
        }        

		/// <summary>
		/// Requests refill permit from the doctor if a prescription has no refills remaining or a refill from the 
		/// pharmacy if the prescription does have refills remaining
		/// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedPrescription.canRequestRefill())
            {
                if (selectedPrescription.RemainingRefills == 0)
                {
                    DialogResult dialogResult = new DialogResult();
                    dialogResult = new ConfirmationPopup("You have no refills remaining.", "Are you sure you want to request a permit for this refill from the doctor?").ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        selectedPrescription.createRefillRequest("Unapproved");
                        selectedPrescription.disableRefillRequest();
                        new AlertDialog("The refill permit was requested.").ShowDialog();
                    }
                }
                else
                {
                    DialogResult dialogResult = new DialogResult();
                    dialogResult = new ConfirmationPopup("You have " + selectedPrescription.RemainingRefills.ToString() + " refills remaining.", "Are you sure you want to request a refill from your pharmacy?").ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        selectedPrescription.createRefillRequest("New");
                        selectedPrescription.disableRefillRequest();
                        new AlertDialog("The refill was requested.").ShowDialog();
                    }
                }                
            }
            else
            {
                new AlertDialog("You have already requested a refill for this prescription.").ShowDialog();
            }
            
        }

    }
}

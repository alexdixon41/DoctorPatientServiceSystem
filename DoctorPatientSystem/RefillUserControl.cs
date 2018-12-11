using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorPatientSystem
{
    public partial class RefillUserControl : UserControl
    {
        public RefillUserControl()
        {
            InitializeComponent();
        }

        private RefillRequest selectedRefillRequest;

        public void populateList()
        {
            newRefillRequestsListView.Items.Clear();
            int i = 0;
            foreach (RefillRequest request in RefillRequest.displayRefillRequests())
            {
                newRefillRequestsListView.Items.Add(request.Status);
                newRefillRequestsListView.Items[i].SubItems.Add(request.Date);
                newRefillRequestsListView.Items[i].SubItems.Add(request.Prescription.PatientName);
                newRefillRequestsListView.Items[i].SubItems.Add(request.Prescription.PrescriberName);
                newRefillRequestsListView.Items[i].SubItems.Add(request.Prescription.Refills.ToString());
                newRefillRequestsListView.Items[i].SubItems.Add(request.Prescription.RemainingRefills.ToString());
                i++;
            }
        }

        private void viewRefillRequestsButton_Click(object sender, EventArgs e)
        {
            if (!(newRefillRequestsListView.SelectedIndices.Count == 0))
            {
                selectedRefillRequest = (RefillRequest)RefillRequest.displayRefillRequests()[newRefillRequestsListView.SelectedIndices[0]];
                listView1.Items.Clear();
                listView2.Items.Clear();

                selectedRefillRequest.Prescription.retrieveMedicines();
                Patient patient = selectedRefillRequest.Prescription.retrievePatientDetails();

                int i = 0;
                foreach (Medicine medicine in patient.MedicineHistory)
                {
                    listView1.Items.Add(medicine.Date);
                    listView1.Items[i].SubItems.Add(medicine.Name);
                    listView1.Items[i].SubItems.Add("" + medicine.Quantity);
                    listView1.Items[i].SubItems.Add(medicine.Dosage);
                    i++;
                }
                i = 0;
                foreach (Medicine medicine in selectedRefillRequest.Prescription.Medicines)
                {
                    listView2.Items.Add(medicine.Name);
                    listView2.Items[i].SubItems.Add("" + medicine.Quantity);
                    listView2.Items[i].SubItems.Add(medicine.Dosage);
                    listView2.Items[i].SubItems.Add(medicine.Route);
                    listView2.Items[i].SubItems.Add(medicine.Instructions);
                    i++;
                }

                //Display patient information    
                generalListView.Items.Clear();
                generalListView.Items.Add("Name: " + patient.Name);
                generalListView.Items.Add("Date of Birth: " + patient.BirthDate);
                generalListView.Items.Add("Height: " + patient.Height);
                generalListView.Items.Add("Weight: " + patient.Weight);
                generalListView.Items.Add("Body Mass Index: " + patient.BodyMassIndex);
                dateLabel.Text = selectedRefillRequest.Date;
                statusLabel.Text = selectedRefillRequest.Status;
                refillsLabel.Text = "" + selectedRefillRequest.Prescription.Refills;
                remainingLabel.Text = "" + selectedRefillRequest.Prescription.RemainingRefills;
                allergyTextBox.Text = patient.Allergies;

                //Disable or enable Accept and Deny buttons depending on RefillRequest status
                if (selectedRefillRequest.Status.ToLower().Equals("unapproved"))
                {
                    acceptButton.Enabled = true;
                    rejectButton.Enabled = true;
                }
                else
                {
                    acceptButton.Enabled = false;
                    rejectButton.Enabled = false;
                }

                newRefillRequestsPanel.Hide();
                prescriptionDetailPanel.Show();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            RefillRequest.retrieveRefillRequests();
            populateList();
            prescriptionDetailPanel.Hide();
            newRefillRequestsPanel.Show();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (new ConfirmationPopup("Are you sure you want to accept this refill permit?",
                "Note: This will send the refill request to the pharmacy").ShowDialog() == DialogResult.OK)
            {
                selectedRefillRequest.changeStatus(RefillRequest.ACCEPTED_STATUS_CODE);
                string message = selectedRefillRequest.Prescription.PrescriberName + 
                    " has granted your refill permit. Your refill request has been sent to " + selectedRefillRequest.Prescription.PharmacyName;
                Notice.sendNotice(selectedRefillRequest.Prescription.PatientId, message, Notice.SEND_REFILL_PERMIT_ACCEPT_NOTICE_TYPE);
                new AlertDialog("The refill permit was accepted.");
                statusLabel.Text = "New";
                rejectButton.Enabled = false;
                acceptButton.Enabled = false;
            }
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            if (new ConfirmationPopup("Are you sure you want to deny this refill permit?",
                "Note: The patient will not be able to request this refill from the pharmacy").ShowDialog() == DialogResult.OK)
            {
                selectedRefillRequest.changeStatus(RefillRequest.DENIED_STATUS_CODE);
                string message = selectedRefillRequest.Prescription.PrescriberName +
                    " has denied your refill permit. Please visit your doctor if you need a new prescription.";
                Notice.sendNotice(selectedRefillRequest.Prescription.PatientId, message, Notice.SEND_REFILL_PERMIT_REJECT_NOTICE_TYPE);
                new AlertDialog("The refill permit was denied.");
                statusLabel.Text = "Denied";
                rejectButton.Enabled = false;
                acceptButton.Enabled = false;
            }
        }
    }
}

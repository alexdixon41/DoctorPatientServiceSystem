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
        public RefillRequest()
        {
            InitializeComponent();
        }

        private void RefillRequest_Load(object sender, EventArgs e)
        {
            // examle listview items
            prescriptionListView.Columns.Add("Name", 150, HorizontalAlignment.Left);
            prescriptionListView.Columns.Add("Date", 100, HorizontalAlignment.Left);
            prescriptionListView.Columns.Add("Dosage", 100, HorizontalAlignment.Left);
            prescriptionListView.Columns.Add("Prescriber", 140, HorizontalAlignment.Left);
            prescriptionListView.Items.Add("Amoxicillin");
            prescriptionListView.Items[0].SubItems.Add("09/18/2018");
            prescriptionListView.Items[0].SubItems.Add("50 mg");
            prescriptionListView.Items[0].SubItems.Add("Dr. Doolittle");
            prescriptionListView.Items.Add("Warfarin");
            prescriptionListView.Items[1].SubItems.Add("06/10/2018");
            prescriptionListView.Items[1].SubItems.Add("25 mg");
            prescriptionListView.Items[1].SubItems.Add("Dr. Doofenschmirtz");
            //
        }

        private void selectPrescriptionButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = new ConfirmationPopup("Are you sure you want to request this refill?", 
                                            "Amoxicillin 50 mg").ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                //TODO request refill
                
                new AlertDialog("The refill was requested.").ShowDialog();
            }
        }
    }
}

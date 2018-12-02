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

            generalHistoryListView.Items.Clear();
            generalHistoryListView.Items.Add("Name: " + patient.Name);
            generalHistoryListView.Items.Add("Date of Birth: " + patient.BirthDate);
        }
    }
}

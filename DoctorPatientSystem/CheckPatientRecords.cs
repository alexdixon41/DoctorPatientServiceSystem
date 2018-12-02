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
        
        public void populateLists(Patient patient)
        {
            generalHistoryListView.Items.Add(patient.Name);
        }
    }
}

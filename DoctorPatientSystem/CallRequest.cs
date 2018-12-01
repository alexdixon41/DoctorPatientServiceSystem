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
    public partial class CallRequest : UserControl
    {
        private string key = "";
        private Doctor selectedDoc = new Doctor();
        private string message;

        public string Message
        {
            get
            {
                return message;
            }

            set
            {
                message = value;
            }
        }

        public CallRequest()
        {
            InitializeComponent();
        }

        public void populateList()
        {
            doctorListView.Items.Clear();
            int i = 0;
            foreach(Doctor doc in Doctor.displayDoctors())
            {
                doctorListView.Items.Add(doc.Name);
                doctorListView.Items[i].SubItems.Add(doc.OfficeName);
                doctorListView.Items[i].SubItems.Add(doc.OfficeNumber);
                i++;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO create phone call request
            selectedDoc = (Doctor)Doctor.displayDoctors()[doctorListView.SelectedIndices.IndexOf(0)];
            Message = "  ";
            Notice.sendNotice(selectedDoc.Id, Message, 4);
        }

        private void CallRequest_Load(object sender, EventArgs e)
        {
            Doctor.retrieveDoctors(key);
            Doctor.displayDoctors();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            key = searchKey.Text;
            if (!searchKey.Text.Equals(null))
            {
                Doctor.retrieveDoctors(key);
                populateList();
            }else
            {
                populateList();
            }
        }
    }
}

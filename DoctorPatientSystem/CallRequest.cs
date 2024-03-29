﻿using System;
using System.Collections;
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

		//displays doctors from the search in the list view
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

		//Creates message and sends a phone call request
        private void button1_Click(object sender, EventArgs e)
        {
            Patient currPatient = new Patient();
            currPatient.retrievePhoneNumber(User.Id);
            if (!(doctorListView.SelectedIndices.Count == 0))
            {
                selectedDoc = (Doctor)Doctor.displayDoctors()[doctorListView.SelectedIndices[0]];    //get the selected doctor
                switch (currPatient.PhoneNums.Count)
                {
                    case 1:
                        message = "" + currPatient.Name + " would like to request an immediate phone call, please call them at " + currPatient.PhoneNums[0];
                        Notice.sendNotice(selectedDoc.Id, message, Notice.SEND_PHONECALL_REQUEST_NOTICE_TYPE);
                        new AlertDialog("Your phone call request has been sent.").ShowDialog();
                        break;
                    case 2:
                        message = "" + currPatient.Name + " would like to request an immediate phone call, please call them at " + currPatient.PhoneNums[0] + ", or " + currPatient.PhoneNums[1];
                        Notice.sendNotice(selectedDoc.Id, message, Notice.SEND_PHONECALL_REQUEST_NOTICE_TYPE);
                        new AlertDialog("Your phone call request has been sent.").ShowDialog();
                        break;
                    case 3:
                        message = "" + currPatient.Name + " would like to request an immediate phone call, please call them at " + currPatient.PhoneNums[0] + ", " + currPatient.PhoneNums[1] + ", or " + currPatient.PhoneNums[2];
                        Notice.sendNotice(selectedDoc.Id, message, Notice.SEND_PHONECALL_REQUEST_NOTICE_TYPE);
                        new AlertDialog("Your phone call request has been sent.").ShowDialog();
                        break;
                    default:
                        AlertDialog noPhoneAlert = new AlertDialog("You have no phone number listed in our systems. Please contact your systems administrator.");
                        noPhoneAlert.ShowDialog();
                        break;
                }
            }
        }

		//Searches for doctors and displays results in the listview
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchKey.Text.Equals("Search for a doctor"))
            {
                searchKey.Text = "";
            }            
            Doctor.retrieveDoctors(key);
            populateList();    
        }

		//Removes default text from search bar 
        private void searchKey_Click(object sender, EventArgs e)
        {
            searchKey.Text = "";
            searchKey.ForeColor = Color.Black;
        }
    }
}

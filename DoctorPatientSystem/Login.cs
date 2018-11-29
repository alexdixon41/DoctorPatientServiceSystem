﻿using System;
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
    public partial class Login : Form
    {
        public static bool loginSuccess = false;

        private int userType = -1;

        public Login()
        {
            InitializeComponent();
        }

        private void doctorButton_Click(object sender, EventArgs e)
        {            
            textBox1.Text = "";
            textBox2.Text = "";
            loginTitleLabel.Text = "Doctor Login";
            loginMenuPanel.Hide();
            loginPanel.Show();
            textBox1.Select();
            userType = User.DOCTOR_USER_TYPE;
        }

        private void patientButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            loginTitleLabel.Text = "Patient Login";
            loginMenuPanel.Hide();
            loginPanel.Show();
            textBox1.Select();
            userType = User.PATIENT_USER_TYPE;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            loginPanel.Hide();
            loginMenuPanel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (User.authenticate(userType, textBox1.Text, textBox2.Text))
            {
                loginSuccess = true;
                this.Close();
            }
            else
                new AlertDialog("Incorrect username or password").ShowDialog();

        }

    }
}

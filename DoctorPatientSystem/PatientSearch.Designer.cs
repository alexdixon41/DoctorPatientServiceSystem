namespace DoctorPatientSystem
{
    partial class PatientSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fnameLabel = new System.Windows.Forms.Label();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nameSearch = new System.Windows.Forms.Button();
            this.patientBox = new System.Windows.Forms.GroupBox();
            this.patientView = new System.Windows.Forms.ListView();
            this.viewPatientInformation = new System.Windows.Forms.Button();
            this.fName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.patientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.patientBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Location = new System.Drawing.Point(20, 16);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(57, 13);
            this.fnameLabel.TabIndex = 0;
            this.fnameLabel.Text = "First Name";
            // 
            // lNameLabel
            // 
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.Location = new System.Drawing.Point(266, 16);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lNameLabel.TabIndex = 1;
            this.lNameLabel.Text = "Last Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(269, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 20);
            this.textBox2.TabIndex = 3;
            // 
            // nameSearch
            // 
            this.nameSearch.Location = new System.Drawing.Point(499, 30);
            this.nameSearch.Name = "nameSearch";
            this.nameSearch.Size = new System.Drawing.Size(75, 23);
            this.nameSearch.TabIndex = 4;
            this.nameSearch.Text = "Search";
            this.nameSearch.UseVisualStyleBackColor = true;
            this.nameSearch.Click += new System.EventHandler(this.nameSearch_Click);
            // 
            // patientBox
            // 
            this.patientBox.Controls.Add(this.patientView);
            this.patientBox.Location = new System.Drawing.Point(16, 57);
            this.patientBox.Name = "patientBox";
            this.patientBox.Size = new System.Drawing.Size(582, 236);
            this.patientBox.TabIndex = 5;
            this.patientBox.TabStop = false;
            this.patientBox.Text = "Patient View";
            // 
            // patientView
            // 
            this.patientView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fName,
            this.lName,
            this.patientID,
            this.DOB});
            this.patientView.FullRowSelect = true;
            this.patientView.Location = new System.Drawing.Point(7, 20);
            this.patientView.Name = "patientView";
            this.patientView.Size = new System.Drawing.Size(567, 210);
            this.patientView.TabIndex = 0;
            this.patientView.UseCompatibleStateImageBehavior = false;
            this.patientView.View = System.Windows.Forms.View.Details;
            // 
            // viewPatientInformation
            // 
            this.viewPatientInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.viewPatientInformation.Location = new System.Drawing.Point(195, 299);
            this.viewPatientInformation.Name = "viewPatientInformation";
            this.viewPatientInformation.Size = new System.Drawing.Size(250, 57);
            this.viewPatientInformation.TabIndex = 6;
            this.viewPatientInformation.Text = "View Patient Information";
            this.viewPatientInformation.UseVisualStyleBackColor = true;
            this.viewPatientInformation.Click += new System.EventHandler(this.viewPatientInformation_Click);
            // 
            // fName
            // 
            this.fName.Text = "First Name";
            this.fName.Width = 140;
            // 
            // lName
            // 
            this.lName.Text = "Last Name";
            this.lName.Width = 140;
            // 
            // patientID
            // 
            this.patientID.Text = "Patient ID";
            this.patientID.Width = 140;
            // 
            // DOB
            // 
            this.DOB.Text = "Date Of Birth";
            this.DOB.Width = 140;
            // 
            // PatientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 368);
            this.Controls.Add(this.viewPatientInformation);
            this.Controls.Add(this.patientBox);
            this.Controls.Add(this.nameSearch);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lNameLabel);
            this.Controls.Add(this.fnameLabel);
            this.Name = "PatientSearch";
            this.Text = "Patient Search";
            this.Load += new System.EventHandler(this.PatientSearch_Load);
            this.patientBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button nameSearch;
        private System.Windows.Forms.GroupBox patientBox;
        private System.Windows.Forms.ListView patientView;
        private System.Windows.Forms.Button viewPatientInformation;
        private System.Windows.Forms.ColumnHeader fName;
        private System.Windows.Forms.ColumnHeader lName;
        private System.Windows.Forms.ColumnHeader patientID;
        private System.Windows.Forms.ColumnHeader DOB;
    }
}
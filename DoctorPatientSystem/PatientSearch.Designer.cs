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
			this.patientSearchTextBox = new System.Windows.Forms.TextBox();
			this.nameSearch = new System.Windows.Forms.Button();
			this.patientBox = new System.Windows.Forms.GroupBox();
			this.patientView = new System.Windows.Forms.ListView();
			this.fName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.patientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.viewPatientInformation = new System.Windows.Forms.Button();
			this.patientBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// fnameLabel
			// 
			this.fnameLabel.AutoSize = true;
			this.fnameLabel.Location = new System.Drawing.Point(27, 20);
			this.fnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.fnameLabel.Name = "fnameLabel";
			this.fnameLabel.Size = new System.Drawing.Size(135, 17);
			this.fnameLabel.TabIndex = 0;
			this.fnameLabel.Text = "Enter Patient Name:";
			// 
			// patientSearchTextBox
			// 
			this.patientSearchTextBox.Location = new System.Drawing.Point(31, 39);
			this.patientSearchTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.patientSearchTextBox.Name = "patientSearchTextBox";
			this.patientSearchTextBox.Size = new System.Drawing.Size(646, 22);
			this.patientSearchTextBox.TabIndex = 2;
			// 
			// nameSearch
			// 
			this.nameSearch.Location = new System.Drawing.Point(685, 36);
			this.nameSearch.Margin = new System.Windows.Forms.Padding(4);
			this.nameSearch.Name = "nameSearch";
			this.nameSearch.Size = new System.Drawing.Size(100, 28);
			this.nameSearch.TabIndex = 4;
			this.nameSearch.Text = "Search";
			this.nameSearch.UseVisualStyleBackColor = true;
			this.nameSearch.Click += new System.EventHandler(this.nameSearch_Click);
			// 
			// patientBox
			// 
			this.patientBox.Controls.Add(this.patientView);
			this.patientBox.Location = new System.Drawing.Point(21, 70);
			this.patientBox.Margin = new System.Windows.Forms.Padding(4);
			this.patientBox.Name = "patientBox";
			this.patientBox.Padding = new System.Windows.Forms.Padding(4);
			this.patientBox.Size = new System.Drawing.Size(776, 290);
			this.patientBox.TabIndex = 5;
			this.patientBox.TabStop = false;
			this.patientBox.Text = "Patient View";
			// 
			// patientView
			// 
			this.patientView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fName,
            this.patientID,
            this.DOB});
			this.patientView.FullRowSelect = true;
			this.patientView.Location = new System.Drawing.Point(9, 25);
			this.patientView.Margin = new System.Windows.Forms.Padding(4);
			this.patientView.Name = "patientView";
			this.patientView.Size = new System.Drawing.Size(755, 258);
			this.patientView.TabIndex = 0;
			this.patientView.UseCompatibleStateImageBehavior = false;
			this.patientView.View = System.Windows.Forms.View.Details;
			// 
			// fName
			// 
			this.fName.Text = "Name";
			this.fName.Width = 140;
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
			// viewPatientInformation
			// 
			this.viewPatientInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.viewPatientInformation.Location = new System.Drawing.Point(260, 368);
			this.viewPatientInformation.Margin = new System.Windows.Forms.Padding(4);
			this.viewPatientInformation.Name = "viewPatientInformation";
			this.viewPatientInformation.Size = new System.Drawing.Size(333, 70);
			this.viewPatientInformation.TabIndex = 6;
			this.viewPatientInformation.Text = "View Patient Information";
			this.viewPatientInformation.UseVisualStyleBackColor = true;
			this.viewPatientInformation.Click += new System.EventHandler(this.viewPatientInformation_Click);
			// 
			// PatientSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.viewPatientInformation);
			this.Controls.Add(this.patientBox);
			this.Controls.Add(this.nameSearch);
			this.Controls.Add(this.patientSearchTextBox);
			this.Controls.Add(this.fnameLabel);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "PatientSearch";
			this.Size = new System.Drawing.Size(832, 453);
			this.Load += new System.EventHandler(this.PatientSearch_Load);
			this.patientBox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.TextBox patientSearchTextBox;
        private System.Windows.Forms.Button nameSearch;
        private System.Windows.Forms.GroupBox patientBox;
        private System.Windows.Forms.ListView patientView;
        private System.Windows.Forms.Button viewPatientInformation;
        private System.Windows.Forms.ColumnHeader fName;
        private System.Windows.Forms.ColumnHeader patientID;
        private System.Windows.Forms.ColumnHeader DOB;
    }
}
namespace DoctorPatientSystem
{
    partial class RefillRequest
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
            this.label1 = new System.Windows.Forms.Label();
            this.prescriptionListView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.selectPrescriptionButton = new System.Windows.Forms.Button();
            this.prescriptionsPanel = new System.Windows.Forms.Panel();
            this.prescriptionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Request a Prescription Refill";
            // 
            // prescriptionListView
            // 
            this.prescriptionListView.FullRowSelect = true;
            this.prescriptionListView.Location = new System.Drawing.Point(18, 99);
            this.prescriptionListView.Name = "prescriptionListView";
            this.prescriptionListView.Size = new System.Drawing.Size(802, 245);
            this.prescriptionListView.TabIndex = 1;
            this.prescriptionListView.UseCompatibleStateImageBehavior = false;
            this.prescriptionListView.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Prescription";
            // 
            // selectPrescriptionButton
            // 
            this.selectPrescriptionButton.Location = new System.Drawing.Point(619, 350);
            this.selectPrescriptionButton.Name = "selectPrescriptionButton";
            this.selectPrescriptionButton.Size = new System.Drawing.Size(201, 34);
            this.selectPrescriptionButton.TabIndex = 3;
            this.selectPrescriptionButton.Text = "Request Selected Refill";
            this.selectPrescriptionButton.UseVisualStyleBackColor = true;
            this.selectPrescriptionButton.Click += new System.EventHandler(this.selectPrescriptionButton_Click);
            // 
            // prescriptionsPanel
            // 
            this.prescriptionsPanel.Controls.Add(this.selectPrescriptionButton);
            this.prescriptionsPanel.Controls.Add(this.label1);
            this.prescriptionsPanel.Controls.Add(this.label2);
            this.prescriptionsPanel.Controls.Add(this.prescriptionListView);
            this.prescriptionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prescriptionsPanel.Location = new System.Drawing.Point(0, 0);
            this.prescriptionsPanel.Name = "prescriptionsPanel";
            this.prescriptionsPanel.Size = new System.Drawing.Size(832, 453);
            this.prescriptionsPanel.TabIndex = 4;
            // 
            // RefillRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.prescriptionsPanel);
            this.Name = "RefillRequest";
            this.Text = "RefillRequest";
            this.Load += new System.EventHandler(this.RefillRequest_Load);
            this.prescriptionsPanel.ResumeLayout(false);
            this.prescriptionsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView prescriptionListView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selectPrescriptionButton;
        private System.Windows.Forms.Panel prescriptionsPanel;
    }
}
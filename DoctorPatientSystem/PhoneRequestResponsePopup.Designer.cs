namespace DoctorPatientSystem
{
	partial class PhoneRequestResponsePopup
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.confirmButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(13, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(556, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Are you sure you want to accept this phone call request?";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(15, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "Patient:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.label3.Location = new System.Drawing.Point(86, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 18);
			this.label3.TabIndex = 3;
			this.label3.Text = "Jenny Johnson";
			// 
			// confirmButton
			// 
			this.confirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.confirmButton.Location = new System.Drawing.Point(351, 157);
			this.confirmButton.Name = "confirmButton";
			this.confirmButton.Size = new System.Drawing.Size(95, 34);
			this.confirmButton.TabIndex = 11;
			this.confirmButton.Text = "Confirm";
			this.confirmButton.UseVisualStyleBackColor = true;
			this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cancelButton.Location = new System.Drawing.Point(474, 157);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(95, 34);
			this.cancelButton.TabIndex = 12;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(15, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 18);
			this.label4.TabIndex = 13;
			this.label4.Text = "Phone:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.label5.Location = new System.Drawing.Point(86, 91);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 18);
			this.label5.TabIndex = 14;
			this.label5.Text = "867-5309";
			// 
			// PhoneRequestResponsePopup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(632, 203);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.confirmButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "PhoneRequestResponsePopup";
			this.Text = "PhoneRequestResponsePopup";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button confirmButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}
namespace DoctorPatientSystem
{
	partial class PhoneRequestResponse
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
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.messageTextBox = new System.Windows.Forms.RichTextBox();
			this.acceptButton = new System.Windows.Forms.Button();
			this.denyButton = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(27, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(198, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Request Details";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(32, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Sender:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label3.Location = new System.Drawing.Point(112, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Jenny Johnson";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(32, 114);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(139, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Time Received:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label5.Location = new System.Drawing.Point(177, 114);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(173, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "10/05/2018 09:45 a.m.";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.label6.Location = new System.Drawing.Point(32, 192);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(90, 20);
			this.label6.TabIndex = 5;
			this.label6.Text = "Message:";
			// 
			// messageTextBox
			// 
			this.messageTextBox.Location = new System.Drawing.Point(36, 215);
			this.messageTextBox.Name = "messageTextBox";
			this.messageTextBox.ReadOnly = true;
			this.messageTextBox.Size = new System.Drawing.Size(396, 150);
			this.messageTextBox.TabIndex = 6;
			this.messageTextBox.Text = "";
			// 
			// acceptButton
			// 
			this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.acceptButton.Location = new System.Drawing.Point(436, 386);
			this.acceptButton.Name = "acceptButton";
			this.acceptButton.Size = new System.Drawing.Size(94, 34);
			this.acceptButton.TabIndex = 9;
			this.acceptButton.Text = "Accept";
			this.acceptButton.UseVisualStyleBackColor = true;
			this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
			// 
			// denyButton
			// 
			this.denyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.denyButton.Location = new System.Drawing.Point(566, 386);
			this.denyButton.Name = "denyButton";
			this.denyButton.Size = new System.Drawing.Size(94, 34);
			this.denyButton.TabIndex = 10;
			this.denyButton.Text = "Deny";
			this.denyButton.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.label7.Location = new System.Drawing.Point(32, 157);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(67, 20);
			this.label7.TabIndex = 11;
			this.label7.Text = "Phone:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label8.Location = new System.Drawing.Point(105, 157);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(78, 20);
			this.label8.TabIndex = 12;
			this.label8.Text = "867-5309";
			// 
			// PhoneRequestResponse
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(832, 453);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.denyButton);
			this.Controls.Add(this.acceptButton);
			this.Controls.Add(this.messageTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "PhoneRequestResponse";
			this.Text = "PhoneRequestResponse";
			this.Load += new System.EventHandler(this.PhoneRequestResponse_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RichTextBox messageTextBox;
		private System.Windows.Forms.Button acceptButton;
		private System.Windows.Forms.Button denyButton;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
	}
}
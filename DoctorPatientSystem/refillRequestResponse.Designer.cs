namespace DoctorPatientSystem
{
	partial class RefillRequestResponse
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
			this.prescriptionDetailsListView = new System.Windows.Forms.ListView();
			this.label2 = new System.Windows.Forms.Label();
			this.messageTextBox = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.acceptButton = new System.Windows.Forms.Button();
			this.denyButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Prescription Details:";
			// 
			// prescriptionDetailsListView
			// 
			this.prescriptionDetailsListView.Location = new System.Drawing.Point(17, 36);
			this.prescriptionDetailsListView.Name = "prescriptionDetailsListView";
			this.prescriptionDetailsListView.Size = new System.Drawing.Size(389, 172);
			this.prescriptionDetailsListView.TabIndex = 1;
			this.prescriptionDetailsListView.UseCompatibleStateImageBehavior = false;
			this.prescriptionDetailsListView.View = System.Windows.Forms.View.List;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label2.Location = new System.Drawing.Point(13, 211);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Message:";
			// 
			// messageTextBox
			// 
			this.messageTextBox.Location = new System.Drawing.Point(17, 234);
			this.messageTextBox.Name = "messageTextBox";
			this.messageTextBox.ReadOnly = true;
			this.messageTextBox.Size = new System.Drawing.Size(389, 105);
			this.messageTextBox.TabIndex = 3;
			this.messageTextBox.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label3.Location = new System.Drawing.Point(14, 354);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Arrival time:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label4.Location = new System.Drawing.Point(122, 354);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(173, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "10/05/2018 12:04 p.m.";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label5.Location = new System.Drawing.Point(14, 389);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 20);
			this.label5.TabIndex = 6;
			this.label5.Text = "Sender:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label6.Location = new System.Drawing.Point(122, 389);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(87, 20);
			this.label6.TabIndex = 7;
			this.label6.Text = "Bob Smith";
			// 
			// acceptButton
			// 
			this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.acceptButton.Location = new System.Drawing.Point(403, 407);
			this.acceptButton.Name = "acceptButton";
			this.acceptButton.Size = new System.Drawing.Size(94, 34);
			this.acceptButton.TabIndex = 8;
			this.acceptButton.Text = "Accept";
			this.acceptButton.UseVisualStyleBackColor = true;
			this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
			// 
			// denyButton
			// 
			this.denyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.denyButton.Location = new System.Drawing.Point(527, 407);
			this.denyButton.Name = "denyButton";
			this.denyButton.Size = new System.Drawing.Size(94, 34);
			this.denyButton.TabIndex = 9;
			this.denyButton.Text = "Deny";
			this.denyButton.UseVisualStyleBackColor = true;
			// 
			// refillRequestResponse
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(832, 453);
			this.Controls.Add(this.denyButton);
			this.Controls.Add(this.acceptButton);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.messageTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.prescriptionDetailsListView);
			this.Controls.Add(this.label1);
			this.Name = "refillRequestResponse";
			this.Text = "refillRequestResponse";
			this.Load += new System.EventHandler(this.refillRequestResponse_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView prescriptionDetailsListView;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox messageTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button acceptButton;
		private System.Windows.Forms.Button denyButton;
	}
}
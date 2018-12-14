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

    /// <summary>
    /// Generic AlertDialog to display a simple message with a single OK button to close.
    /// The constructor parameter messageText sets the message displayed in the alert.
    /// </summary>
    public partial class AlertDialog : Form
    {
        String messageText;                   //Text to be displayed in AlertDialog

        public AlertDialog(String messageText)
        {
            this.messageText = messageText;
            InitializeComponent();
        }

        private void AlertDialog_Load(object sender, EventArgs e)
        {
            primaryText.Text = messageText;
        }
    }
}

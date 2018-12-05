using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorPatientSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

            if (Login.loginSuccess)
            {
                if (User.Type == User.DOCTOR_USER_TYPE)
                    Application.Run(new DoctorMenu());
                else if (User.Type == User.PATIENT_USER_TYPE)
                    Application.Run(new PatientMenu());
            }
        }

    }
}

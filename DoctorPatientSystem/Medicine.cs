using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorPatientSystem
{
    class Medicine
    {
        private string date;
        private string name;
        private int quantity;
        private string dosage;
        private string route;
        private string instructions;
        private int prescriptionID;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }
        public string Dosage
        {
            get
            {
                return dosage;
            }

            set
            {
                dosage = value;
            }
        }
        public string Route
        {
            get
            {
                return route;
            }

            set
            {
                route = value;
            }
        }
        public string Instructions
        {
            get
            {
                return instructions;
            }

            set
            {
                instructions = value;
            }
        }
        public int PrescriptionID
        {
            get
            {
                return prescriptionID;
            }

            set
            {
                prescriptionID = value;
            }
        }
        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public static void createMedicine(ArrayList medicines, int prescriptionID)
        {

        }
    }
}

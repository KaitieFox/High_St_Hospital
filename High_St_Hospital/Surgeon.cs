using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_St_Hospital
{
    class Surgeon : Doctor
    {
        //fields
        private bool operating;

        //properties
        public bool Operating
        {
            get { return this.operating; }
            set { this.operating = value; }
        }

        //constructors
        public Surgeon()
        {

        }

        public Surgeon(string employeeName, int employeeNumber, string specialtyArea)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.specialtyArea = specialtyArea;
            bool operating = false;
        }


    }
}

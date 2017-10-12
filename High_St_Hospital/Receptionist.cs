using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_St_Hospital
{
    class Receptionist : Departmental_Employee
    {
        //fields
        private bool onPhone;

        //properties
        public bool OnPhone
        {
            get { return this.onPhone; }
            set { this.onPhone = value; }
        }

        //constructor
        public Receptionist()
        {

        }

        public Receptionist(string employeeName, int employeeNumber, string department)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
        }





    }
}

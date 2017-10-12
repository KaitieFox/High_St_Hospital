using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_St_Hospital
{
    abstract class Departmental_Employee : General_Employee
    {
        //fields
        protected string department;

        //properties
        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        //Constructor??
        public Departmental_Employee()
        {

        }
        
        public Departmental_Employee(string employeeName, int employeeNumber, string department)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
        }
        ////let's talk about what this means with Do Not Repeat thyself.



    }
}

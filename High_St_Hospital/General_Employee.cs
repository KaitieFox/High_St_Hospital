using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_St_Hospital
{
    class General_Employee
    {
        //fields
        protected string employeeName;
        protected int employeeNumber;


        //properties
        public string EmployeeName
        {
            get { return this.employeeName; }
        }

        public int EmployeeNumber
        {
            get { return this.employeeNumber; }
        }

        //constructor
        public General_Employee()
        {

        }

        public General_Employee(string employeeName, int employeeNumber)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
        }






    }
}

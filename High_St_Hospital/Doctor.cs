using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_St_Hospital
{
    class Doctor : General_Employee
    {
        //fields
        protected string specialtyArea;

        //properties
        public string SpecialtyArea
        {
            get { return this.specialtyArea; }
        }

        //constructors
        public Doctor()
        {

        }

        public Doctor(string employeeName, int employeeNumber, string specialtyArea)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.specialtyArea = specialtyArea;
        }


    }
}

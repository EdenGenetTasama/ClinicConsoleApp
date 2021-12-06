using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicConsoleApp
{
    internal class Employee
    {
        private string firstName;
        private string lastName;
        private string part;


        public Employee(string _firstName, string _lastName, string _part)
        {
            this.firstName = _firstName;
            this.lastName = _lastName;
            this.part = _part;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string Part
        {
            get { return this.part; }
            set { this.part = value; }
        }


    }
}

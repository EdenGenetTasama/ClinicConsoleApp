using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicConsoleApp
{
    internal class Doctor : Employee, IComparable
    {
        private int numberOfPatient;
        private int yearOfBirth;


        public Doctor(int numberOfPatient, int yearOfBirth, string _firstName, string _lastName, string _part) : base(_firstName, _lastName, _part)
        {

            this.numberOfPatient = numberOfPatient;
            this.yearOfBirth = yearOfBirth;


        }

        public int NumberOfPatient
        {
            get { return this.numberOfPatient; }
            set { this.numberOfPatient = value; }
        }
        public int YearOfBirth
        {
            get { return this.yearOfBirth; }
            set { this.yearOfBirth = value; }
        }


        public int CompareTo(object obj)
        {
            Doctor p = (Doctor)obj;
            if (this.numberOfPatient < p.NumberOfPatient) return -1;
            if (this.numberOfPatient > p.NumberOfPatient) return 1;
            return 0;
        }
    }
}

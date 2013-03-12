using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{
    class SalariedEmployee : Employee
    {
        private decimal weeklySalary;

        // four-parameter constructor
        public SalariedEmployee(string first, string last, string ssn, decimal salary)
            : base(first, last, ssn)
        {
            WeeklySalary = salary; // validate salary via property
        } // end four-parameter SalariedEmployee constructor

        // property that gets and sets salaried employee's salary
        public decimal WeeklySalary
        {
            get
            {
                return weeklySalary;
            } // end get
            set
            {
                if (value >= 0) // validation
                    weeklySalary = value;
                else
                    throw new ArgumentOutOfRangeException("WeeklySalary", value, "WeeklySalary must be >= 0");
            } // end set
        } // end property WeeklySalary

        // calculate GetPaymentAmount; implement interface IPayable method
        // that was abstract in base class Employee
        public override decimal GetPaymentAmount()
        {
            return WeeklySalary;
        } // end method GetPaymentAmount

        // return SIMPLE string representation of SalariedEmployee object
        public override string ToString()
        {
            return string.Format("{0}{1,15:C}",
                base.ToString(), GetPaymentAmount());
        } // end method ToString

        // return COMPLETE string representation of SalariedEmployee object
        public override string ToString(int selection)
        {            
            return string.Format("{0}{1,15:C}",
                base.ToString(selection), GetPaymentAmount());
        } // end method ToString
    }
}

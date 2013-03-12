using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{
    public class HourlyEmployee : Employee
    {   
        private decimal wage; // wage per hour
        private decimal hours; // hours worked for the week

        // five-parameter constructor
        public HourlyEmployee(string first, string last, string ssn, decimal hourlyWage, decimal hoursWorked) 
                            : base(first, last, ssn)
        {
            Wage = hourlyWage; // validate hourly wage via property
            Hours = hoursWorked; // validate hours worked via property
        } // end five-parameter HourlyEmployee constructor

        // property that gets and sets hourly employee's wage
        public decimal Wage
        {
            get
            {
                return wage;
            } // end get
            set
            {
                if (value >= 0) // validation
                    wage = value;
                else
                    throw new ArgumentOutOfRangeException("Wage", value, "Wage must be >= 0");
            } // end set
        } // end property Wage

        // property that gets and sets hourly employee's hours
        public decimal Hours
        {
            get
            {
                return hours;
            } // end get
            set
            {
                if (value >= 0 && value <= 168) // validation
                    hours = value;
                else
                    throw new ArgumentOutOfRangeException("Hours", value, "Hours must be >= 0 and <= 168");
            } // end set
        } // end property Hours

        // calculate GetPaymentAmount; implement interface IPayable method
        // that was abstract in base class Employee
        public override decimal GetPaymentAmount()
        {
            if (Hours <= 40) // no overtime                          
                return Wage * Hours;
            else
                return (40 * Wage) + ((Hours - 40) * Wage * 1.5M);
        } // end method GetPaymentAmount                    

        // return SIMPLE string representation of HourlyEmployee object
        public override string ToString()
        {
            return string.Format("{0}{1,15:C}",
                            base.ToString(), GetPaymentAmount());
        } // end method ToString

        // return COMPLETE string representation of SalariedEmployee object
        public override string ToString(int selection)
        {
            return string.Format("{0}{1,10:C}{2,18:C}{3,14:F1}", 
                            base.ToString(selection), GetPaymentAmount(), Wage, Hours);
        } // end method ToString 
    }
}

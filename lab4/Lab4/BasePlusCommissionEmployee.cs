using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{
    class BasePlusCommissionEmployee : CommissionEmployee
    {
        private decimal baseSalary; // base salary per week

        // six-parameter constructor
        public BasePlusCommissionEmployee(string first, string last, string ssn,
                                        decimal sales, decimal rate, decimal salary) :
            base(first, last, ssn, sales, rate)
        {
            BaseSalary = salary; // validate base salary via property
        } // end six-parameter BasePlusCommissionEmployee constructor

        // property that gets and sets 
        // base-salaried commission employee's base salary
        public decimal BaseSalary
        {
            get
            {
                return baseSalary;
            } // end get
            set
            {
                if (value >= 0)
                    baseSalary = value;
                else
                    throw new ArgumentOutOfRangeException("BaseSalary", value, "BaseSalary must be >= 0");
            } // end set
        } // end property BaseSalary

        // calculate GetPaymentAmount; implement interface IPayable method
        // that was abstract in base class Employee
        public override decimal GetPaymentAmount()
        {
            return BaseSalary + base.GetPaymentAmount();
        } // end method GetPaymentAmount

        // return string representation of BasePlusCommissionEmployee object
        public override string ToString()
        {
            return string.Format("{0}{1,15:C}",
                          base.ToString().Substring(0, 47), GetPaymentAmount());
        } // end method ToString
        
        public override string ToString(int selection)
        {
            return string.Format("{0}{1,12:C}{2,14:C}{3,14:C}{4,12:P1}",
                          base.ToString(selection).Substring(0,47), GetPaymentAmount(), BaseSalary, GrossSales, CommissionRate);           
        } // end method ToString
    }
}

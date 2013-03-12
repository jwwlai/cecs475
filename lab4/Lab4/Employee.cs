using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{
    public abstract class Employee : IPayable, IComparable<Employee>
    {
        // read-only property that gets employee's first name
        public string FirstName { get; private set; }

        // read-only property that gets employee's last name
        public string LastName { get; private set; }

        // read-only property that gets employee's social security number
        public string SocialSecurityNumber { get; private set; }

        // three-parameter constructor
        public Employee(string first, string last, string ssn)
        {
            FirstName = first;
            LastName = last;
            SocialSecurityNumber = ssn;
        } // end three-parameter Employee constructor

        // return string representation of Employee object
        public override string ToString()
        {
            return string.Format("{0,-15} {1,-15} {2,-15}", 
                                FirstName, LastName, SocialSecurityNumber);
        } // end method ToString

        public virtual string ToString(int selection)
        {
            return string.Format("{0,-15} {1,-15} {2,-15}",
                                FirstName, LastName, SocialSecurityNumber);

        } // end method ToString

        // Abstract class implemented by the children of Employee
        public abstract decimal GetPaymentAmount();

        //Default compare method = SSN 
        public int CompareTo(Employee e)
        {
            if (e == null) return 1;
            return this.SocialSecurityNumber.CompareTo(e.SocialSecurityNumber);
        }

        //Sort by SSN
        public static IComparer<Employee> sortSsn(int sortType)
        {
            return (IComparer<Employee>)new sortSsnHelper(sortType);
        }

        //Sort by First Name
        public static IComparer<Employee> sortFirstName(int sortType)
        {
            return (IComparer<Employee>)new sortFirstNameHelper(sortType);
        }
        
        //Sort by Last Name
        public static IComparer<Employee> sortLastName(int sortType)
        {
            return (IComparer<Employee>)new sortLastNameHelper(sortType);
        }

        //Sort by Pay
        public static IComparer<Employee> sortPay(int sortType)
        {
            return (IComparer<Employee>)new sortPayHelper(sortType);
        }
        
        /******************* HELPER CLASSES ***********************/
        //Sort by SSN HELPER
        private class sortSsnHelper : IComparer<Employee>
        {
            private int sortType = 0;
            public sortSsnHelper(int sort)
            {
                this.sortType = sort;
            }

            int IComparer<Employee>.Compare(Employee a, Employee b)
            {
                Employee e1 = a;
                Employee e2 = b;
                if (sortType == 0)
                {                    
                    return String.Compare(e1.SocialSecurityNumber, e2.SocialSecurityNumber);
                }
                else return String.Compare(e2.SocialSecurityNumber, e1.SocialSecurityNumber);
            }
        }

        //Sort by First Name HELPER
        private class sortFirstNameHelper : IComparer<Employee>
        {
            private int sortType = 0;
            public sortFirstNameHelper(int sort)
            {
                this.sortType = sort;
            }

            int IComparer<Employee>.Compare(Employee a, Employee b)
            {
                Employee e1 = a;
                Employee e2 = b;
                if (sortType == 0)
                {
                    if (e1.FirstName.Equals(e2.FirstName)) //if same first name, sort by last name
                    {
                        return String.Compare(e1.LastName, e2.LastName);
                    }
                    return String.Compare(e1.FirstName, e2.FirstName);
                }
                else return String.Compare(e2.FirstName, e1.FirstName);
            }
        }

        //Sort by Last Name HELPER
        private class sortLastNameHelper : IComparer<Employee>
        {
            private int sortType = 0;
            public sortLastNameHelper(int sort)
            {
                this.sortType = sort;
            }

            int IComparer<Employee>.Compare(Employee a, Employee b)
            {
                Employee e1 = a;
                Employee e2 = b;
                if (sortType == 0)
                {
                    if (e1.LastName.Equals(e2.LastName)) //if same last name, sort by first name
                    {
                        return String.Compare(e1.FirstName, e2.FirstName);
                    }
                    return String.Compare(e1.LastName, e2.LastName);
                }
                else return String.Compare(e2.LastName, e1.LastName);                
            }
        }        

        //Sort by Pay HELPER
        private class sortPayHelper : IComparer<Employee>
        {
            private int sortType = 0;
            public sortPayHelper(int sort)
            {
                this.sortType = sort;
            }

            int IComparer<Employee>.Compare(Employee a, Employee b)
            {
                Employee e1 = a;
                Employee e2 = b;
                if (sortType == 0) return e1.GetPaymentAmount().CompareTo(e2.GetPaymentAmount());
                else return e2.GetPaymentAmount().CompareTo(e1.GetPaymentAmount());
            }
        }         
       
    } // end abstract class Employee
}

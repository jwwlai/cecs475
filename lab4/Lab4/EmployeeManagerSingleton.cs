using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Lab4
{
    public class EmployeeManagerSingleton
    {
        private static EmployeeManagerSingleton instance;
        private List<Employee> listOfEmployees;

        public EmployeeManagerSingleton() //Constructor
        {
            listOfEmployees = new List<Employee>();

            //Default EMPLOYEES
            listOfEmployees.Add(new SalariedEmployee("John", "Smith", "111-11-1111", 800M));
            listOfEmployees.Add(new SalariedEmployee("Antonio", "Smith", "555-55-5555", 1000M));
            listOfEmployees.Add(new SalariedEmployee("Victor", "Smith", "444-44-4444", 1800M));
            listOfEmployees.Add(new HourlyEmployee("Karen", "Price", "222-22-2222", 16.75M, 40M));
            listOfEmployees.Add(new HourlyEmployee("Ruben", "Zamora", "666-66-6666", 20.00M, 40M));
            listOfEmployees.Add(new CommissionEmployee("Sue", "Jones", "333-33-3333", 10000M, .06M));
            listOfEmployees.Add(new BasePlusCommissionEmployee("Bob", "Lewis", "777-77-7777", 5000M, .04M, 300M));
            listOfEmployees.Add(new BasePlusCommissionEmployee("Lee", "Duarte", "888-88-8888", 5000M, .04M, 300M));
        }

        public static EmployeeManagerSingleton Instance  //Property
        {
            get //Lazy instantiation of Singleton
            {
                if (Instance == null) instance = new EmployeeManagerSingleton();
                return Instance;
            }
        }

        public List<Employee> ListOfEmployees
        {
            get
            {
                return this.listOfEmployees;
            }
        }
        
        public Employee createSalaryEmployee(string first, string last, string ssn, decimal salary)
        {
            Employee newSalaryEmployee = new SalariedEmployee(first, last, ssn, salary);
            return newSalaryEmployee;
        }

        public Employee createCommissionEmployee(string first, string last, string ssn, decimal sales, decimal rate)
        {
            Employee newCommissionEmployee = new CommissionEmployee(first, last, ssn, sales, rate);
            return newCommissionEmployee;
        }

        public Employee createBaseCommissionEmployee(string first, string last, string ssn,
                                                decimal sales, decimal rate, decimal salary)
        {
            Employee newBaseCommissionEmployee = new BasePlusCommissionEmployee(first, last, ssn, sales, rate, salary);
            return newBaseCommissionEmployee;
        }

        public Employee createHourlyEmployee(string first, string last, string ssn, decimal hourlyWage, decimal hoursWorked)
        {
            Employee newHourlyEmployee = new HourlyEmployee(first, last, ssn, hourlyWage, hoursWorked);
            return newHourlyEmployee;
        }

        public void addEmployee(Employee e)
        {
            listOfEmployees.Add(e);
        }

        public void sortBySsn(int sort)
        {
            listOfEmployees.Sort(Employee.sortSsn(sort));
        }

        public void sortByFirstName(int sort)
        {
            listOfEmployees.Sort(Employee.sortFirstName(sort));
        }

        public void sortByLastName(int sort)
        {
            listOfEmployees.Sort(Employee.sortLastName(sort));
        }

        public void sortByPay(int sort)
        {
            listOfEmployees.Sort(Employee.sortPay(sort));
        }

        /**
         * Returns a true if the SSN was found. 
         * Returns a false if the SSN was NOT found.
         */
        public Boolean searchBySSN(string SSN)
        {
            //return listOfEmployees.BinarySearch(SSN); CANNOT use this method b/c it uses the default compare to method which takes in an employee type in the parameter
            Boolean found = false;
            foreach (Employee oneEmployee in listOfEmployees)
            {
                if (oneEmployee.SocialSecurityNumber == SSN) found = true;
            }
            return found;
        }

        public String getEmployeeInfo(string SSN)
        {
            String employeeInfo = "Failed to get Employee info";
            foreach (Employee someEmployee in listOfEmployees)
            {
                if (someEmployee.SocialSecurityNumber == SSN)
                    employeeInfo = someEmployee.ToString();
            }
            return employeeInfo;
        }
    }
}

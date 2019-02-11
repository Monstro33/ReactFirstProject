using System;
using System.Collections.Generic;
using System.Text;

namespace University_Hospitals
{
    public class Employee
    {
        public List<Employee> CurrentEmployees { get; set; }
        public int idNumber;//all employees
        public string firstName;//all employees 
        public string lastName;//all employees
        public string jobTitle;//all employees
        public string specialtyArea;
        public int salary;//all employees   
        public bool payEmployees = false;

        public Employee(int idNumber, string firstName, string lastName, string jobTitle, string specialtyArea, int payScale)
        {

            idNumber = idNumber;
            firstName = firstName;
            lastName = lastName;
            jobTitle = jobTitle;
            specialtyArea = specialtyArea;
            salary = salary;
            
            CurrentEmployees = new List<Employee>()
            {
                new Employee(1, "Mike", "Mann", "Doctor", "Emergency Medicine", 90000),
                new Employee(2, "Amber", "Lake", "Nurse", "Critical Care", 50000),
                new Employee(3, "Pam", "Pechuga", "Receptionist", "N/A", 45000),
                new Employee(4, "Brian", "Delago", "Janitor", "N/A", 40000),
            };
        }

        public Employee()
        {
        }

        public void DisplayEmployeeList()
        {
            string type = "";
            for (int i = 0; i > 0; i++)
            Console.WriteLine(" ID | FIRST NAME      | Last Name       | Job Title  | Salary   ");
            Console.WriteLine("   {0}   {1}     {2}    {3}  {4}  {5} ",

                       /*Employee[i].*/idNumber.ToString().PadRight(2),
                      /* Employee[i].*/firstName.ToString().PadRight(8),
                       /*Employee[i].*/lastName.ToString().PadRight(2),
                       /*Employee[i].*/jobTitle.ToString().PadRight(8),
                      /*Employee[i].*/salary.ToString().PadRight(8));
        }

        public void PayAllEmployees()
        {
            payEmployees = true;
        }

        public virtual void DrawBlood()
        {

        }
        public virtual void Care_For_Patient()
        {

        }
    }
}
       




    

       
    

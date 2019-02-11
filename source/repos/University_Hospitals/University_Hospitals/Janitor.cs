using System;
using System.Collections.Generic;
using System.Text;

namespace University_Hospitals
{
    public class Janitor : Employee
    {
        public bool Cleaning = false;
        public Janitor(int idNumber, string firstName, string lastName, string jobTitle, string specialtyArea, int payScale) : base(idNumber, firstName, lastName, jobTitle, specialtyArea, payScale)
        {
        
        }
        public void isCleaning()
        {
            Cleaning = true;
        }
    }
}

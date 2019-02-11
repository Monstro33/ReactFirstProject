using System;
using System.Collections.Generic;
using System.Text;

namespace University_Hospitals
{
    public class Receptionist : Employee
    {
        public bool phoneCall = false;
        public Receptionist(int idNumber, string firstName, string lastName, string jobTitle, string specialtyArea, int payScale) : base(idNumber, firstName, lastName, jobTitle, specialtyArea, payScale)
        {

        }
        public void onPhone()
        {
            phoneCall = true;
        }
    }
}

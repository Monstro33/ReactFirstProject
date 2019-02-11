using System;
using System.Collections.Generic;
using System.Text;

namespace University_Hospitals
{
    public class Doctor : Employee
    {
        public Doctor(int idNumber, string firstName, string lastName, string jobTitle, string specialtyArea, int payScale ): base (idNumber, firstName, lastName, jobTitle, specialtyArea, payScale)
        {

        } 
        public override void DrawBlood()
        {
            //bloodLevel = -5;
            //healthLevel = -2;
        }
        public override void Care_For_Patient()
        {
            //bloodLevel = + 2.5;
            //healthLevel = + 5;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace University_Hospitals
{
    class Nurse : Employee
    {
        public Nurse(int idNumber, string firstName, string lastName, string jobTitle, string specialtyArea, int payScale) : base(idNumber, firstName, lastName, jobTitle, specialtyArea, payScale)
        {

        }
        public override void DrawBlood()
        {
            //bloodLevel = -2.5;
            //healthLevel = -1;
        }
        public override void Care_For_Patient()
        {
            //bloodLevel = + 5;
            //healthLevel = +10;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace University_Hospitals
{
    public class PatientList
    {
        public class Patient
        {
            List<Patient> currentPatients { get; set; }
            public int idNumber;
            public string firstName;
            public string lastName;
            public int healthLevel = 10;
            public float bloodLevel = 20;

            public Patient(int idNumber, string firstName, string lastName, int bloodLevel, int healthLevel)
            {
                idNumber = idNumber;
                firstName = firstName;
                lastName = lastName;
                bloodLevel = bloodLevel;
                healthLevel = healthLevel;

                currentPatients = new List<Patient>()
                {
                    new Patient(1, "Rick", "Ross", 20, 10),
                    new Patient(2, "John", "Mayer", 20, 10),
                    new Patient(3, "Tupac", "Shakur", 20, 10),
                    new Patient(4, "Biggie", "Smalls", 20, 10)
                };

            }

            public void PatientInfo()
            {
                string type = "";
                for (int i = 0; i > 0; i++)
                    Console.WriteLine(" ID | FIRST NAME      | Last Name       | BLOOD LEVEL  | HEALTH LEVEL   ");
                Console.WriteLine("   {0}   {1}     {2}    {3}  {4}  {5} ",

                           /*Employee[i].*/idNumber.ToString().PadRight(2),
                          /* Employee[i].*/firstName.ToString().PadRight(8),
                           /*Employee[i].*/lastName.ToString().PadRight(2),
                           /*Employee[i].*/bloodLevel.ToString().PadRight(8),
                          /*Employee[i].*/healthLevel.ToString().PadRight(8));
            }

            public void Deteriorate()
            {
                healthLevel -= 1;
                bloodLevel -= 2;
            }

            public void PatientDeath()
            {
                if (bloodLevel == 0)
                {
                    Console.WriteLine("Your patient has expired, prepare for a lawsuit");
                }
                else if (healthLevel == 0)
                {
                    Console.WriteLine("Your patient has expired, prepare for a lawsuit");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
namespace University_Hospitals
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            //P
            
        }
        
        static void WelcomeMenu()
        {
            Console.WriteLine("\t\tHello! Welcome to the University Hospitals \n\t\tPatient and Employee Management Syatem.");
            Console.WriteLine("");
            Console.WriteLine("\n\t\t   SELECT FROM THE OPTIONS BELOW:\n");
            Console.WriteLine("\t\t   Press 1 to view all patients");
            Console.WriteLine("\t\t   Press 2 to view all employees");
            Console.WriteLine("\t\t   Press 0 to exit");

            bool running = true;

            while (running)
              {
                    string userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "1"://view all patients
                            Console.Clear();
                        //PatientList.
                        //employee sub menu;
                        Console.WriteLine("\n\n\nPlease select from the options above.");
                            break;
                        case "2"://view all employees
                            Console.Clear();
                            //print employee list();
                            //employee sub menu();
                            Console.WriteLine("\n\n\nPlease select from the options above.");
                            break;
                        case "3": //Pay employee
                            Console.WriteLine("Please type the ID to select the employee you would like pay.");
                            int id = Convert.ToInt32(Console.ReadLine());
                            /*myshelter.Select_Pet(id)*/;
                            Console.Clear();
                            Console.WriteLine("You have just paid ");
                            //employee submenu;
                            Console.WriteLine("\n\n\nPlease select from the options above.");
                        break;
                        case "4":  //pay all employees
                            Console.Clear();    
                            //pay employee
                            Console.WriteLine("All the University Hospital employees have been paid");
                            Console.Clear();
                            //employee submenu;
                            Console.WriteLine("\n\n\nPlease select from the options above.");
                            break;
                        case "5": //draw blood
                            Console.Clear();
                            //print patient list;
                            Console.WriteLine("Please select the patient ID for blood draw.");
                            int selection = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                            break;
                        case "6"://care for patient
                        //    Console.Clear();
                        //    Console.WriteLine("\n 1 -- Doctor draws blood\n 2 -- Nurse draw blood ");
                        //    myshelter.Print_List();
                        //    Console.WriteLine("\nYou played with the whole Shelter");
                        //    myshelter.Playwithall();
                        //    Console.WriteLine("\nPress 2 to see interaction memu again");
                        //    break;
                        //case "7": //took all pets to technician
                        //    Console.Clear();
                        //    myshelter.Checkup();
                        //    Console.WriteLine("\n\t\t\tVirtual Pets, Inc. Shelter\n\t\t\tTerminal Tower, Cleveland\n");
                        //    myshelter.Print_List();
                        //    Console.WriteLine("\nYou took all the pets for a check-up");
                        //    Console.WriteLine("\nPress 2 to see interaction memu again");
                            break;
                        case "0"://Close the program
                            running = false;
                            break;
                        default:
                            Console.WriteLine("You selected an invaild response please select 1 thru 7 to continue or 0 to exit game");
                            break;
                    }
                }
            }
        }
    }


   

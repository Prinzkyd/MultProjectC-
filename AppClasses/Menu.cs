using System;
namespace Mult.AppClasses
{
    internal class Menu
    {
        public Menu(){
            AdminMenu();
        }

        private void AdminMenu(){
            

            
            int userSelection = 5;
                while (userSelection== 5 || userSelection != 4)
                {
                    Console.WriteLine("===========================================================");
                    Console.WriteLine("\t\tAdministrative Menu");
                    Console.WriteLine("===========================================================");

                    Console.WriteLine("1. Registration");
                    Console.WriteLine("2. Display All Registered Students");
                    Console.WriteLine("3. Total number of students");
                    Console.WriteLine("4. Shutdown Application");
                        try
                        {
                            Console.Write("Select Option : ");
                            userSelection = Convert.ToInt32(Console.ReadLine());

                            //REg
                            if (userSelection == 1)
                            {   
                                Student newStudent = new Student();
                                Console.WriteLine("\t\t\t\tData Successfully Sent TO Server");

                            }
                            //Display Students
                            if (userSelection == 2)
                            {
                                string readText = File.ReadAllText("MOGISDB.txt");  
                                Console.WriteLine("================================================================");                    
                            Console.WriteLine("\t\t LIST OF STUDENTS"); 
                            Console.WriteLine("================================================================"); 

                                Console.WriteLine(readText); 
                            }
                            // Number of students
                            if (userSelection == 3)
                            {
                                int NoOfStudents = 0;
                                using (var reader = File.OpenText("MOGISDB.txt"))
                                {
                                    while (reader.ReadLine() != null)
                                    {
                                        NoOfStudents++;
                                    }
                                }
                                Console.WriteLine("Total number of students : " + NoOfStudents);
                            }

                            if (userSelection != 1 && userSelection != 2 && userSelection !=3 && userSelection != 4)
                            {
                                Console.WriteLine("Please select an option above.");
                            }
                            

                        }
                        catch (System.Exception e)
                        {
                            Console.Write("Kindly Enter a number 1-3 : ");
                            userSelection = Convert.ToInt32(Console.ReadLine());
                        }
                }

                
        }
    }
}

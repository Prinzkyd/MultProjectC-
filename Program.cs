using System.Dynamic;
using System;

using Mult.AppClasses;

namespace MultProjectC_
{
    internal class Program
    {
        public static void Main(string[] args)
        {  
            Console.WriteLine("===========================================================================");
            Console.WriteLine("\t\t\tMorning GLory International School App");
            Console.WriteLine("===========================================================================");

            int userSelection= 5;
            string adminPass = "";
                try{
                    userSelectionFUnction();
                }catch{
                    Console.Write("=============================Kindly enter a number from 1-3================================");
                    userSelectionFUnction();
                }
                
                
                Console.WriteLine("Application Shutting Down...");


                void userSelectionFUnction()
                {
                    while(userSelection == 5 && userSelection != 4){
                    Console.WriteLine("");
                    Console.WriteLine("INTERFACE OPTIONS ");
                    Console.WriteLine("1. Admin Login");
                    Console.WriteLine("2. User Registration");
                    Console.WriteLine("3. Access Multiplication Table");
                    Console.WriteLine("4. Shutdown");
                    Console.Write("Select Option :");
                    userSelection = Convert.ToInt32(Console.ReadLine());

                        if (userSelection == 1)
                        {   
                            Console.Write("Enter password : ");
                            adminPass = Convert.ToString(Console.ReadLine());

                            while (adminPass != "admin")
                            {
                                Console.WriteLine("Press quit to return to previous menu ");
                                Console.Write("Wrong Password‼️‼️  Try again : ");
                                adminPass = Convert.ToString(Console.ReadLine());
                                    if (adminPass == "admin")
                                    {
                                        Menu menu = new Menu();
                                    }
                                    if(adminPass == "quit")break;
                            }
                                // Console.WriteLine("Menu accessed successfully");

                            if (adminPass == "admin")
                            {
                                Menu menu = new Menu();
                            }
                        }
                        if(userSelection == 2)
                        {
                            Student student = new Student();
                        }

                        if (userSelection == 3)
                        {
                            string name;
                            string path = "MOGISDB.txt";

                            Console.Write("Enter First Name : ");
                            name = Console.ReadLine();


                                    
                                //Array to string
                                string b = string.Join(",",name);
                                //Validate if exists
                                if(File.ReadAllText(path).Contains(b)){
                                    Console.WriteLine("=====Access Granted=====");
                                    Student.MultTable();
                                }else{
                                    Console.WriteLine("=====Access Denied Not Found=====");
                                }
                                
                        }

                }//end of while
                }
            
        }//end of main func
    }
}

// validation for this Menu
using System;
using System.IO;
using System.Text;
namespace Mult.AppClasses
{
    internal class Student
    {
        string email;
        const  float FeesLevel1 = 650;
        const  float FeesLevel2 = 600;
        const  float FeesLevel3 = 600;
        const  float FeesLevel4 = 600;
        const  float FeesLevel5 = 600;
        const  float FeesLevel6 = 600;
        const  float FeesLevel7 = 700;
        const  float FeesLevel8 = 700;
        const  float FeesLevel9 = 1000;

        int level;
        double feesPaying;
        double feeBalance;


        DateTime nowDate;

        public static int TotalNoStudents;
        public string StudentFirstName { get; set; }
        public string StudentMiddleName {get;set;}
        public string StudentLastName { get; set;}
        public bool Married;
        public string StudentEmail { get; set; }
        public string StudentLevel{get;set;}



        // Constructor 
        public Student(){

            TakeREgDetails();
            displayRegDetails();
        }


        public void TakeREgDetails(){
            // FirstName
            Console.Write("Enter student first name: ");
            this.StudentFirstName = Console.ReadLine();
                while (StudentFirstName=="")
                {
                    Console.Write("First student name is required : ");
                    this.StudentFirstName = Console.ReadLine();
                }

            // MIddleName
            Console.Write("Enter the student middle name (Optional):");
            this.StudentMiddleName = Console.ReadLine();

            // LAstName
            Console.Write("Enter the student last name :");
            this.StudentLastName = Console.ReadLine();
                while (StudentLastName=="")
                {
                    Console.Write("Last student name is required : ");
                    this.StudentLastName = Console.ReadLine();
                }

            //MArried
            try
            {
                Console.Write("Married? True/False :");
                this.Married = Convert.ToBoolean(Console.ReadLine());
            }
            catch (System.Exception e)
            {
                Console.Write("Kindly enter True/False : ");
                this.Married = Convert.ToBoolean(Console.ReadLine());
            }

            // Email
            Console.Write("Enter student email address : ");;
            this.email = Convert.ToString(Console.ReadLine());

            // Fees
            Console.Write("Level of student. 1-9 : ");
            this.level = Convert.ToInt32(Console.ReadLine());
                try
                {
                    while (level < 1 || level > 9)
                    {
                        Console.WriteLine("Entered the wrong level ");
                        Console.Write("Kindly Reenter Level; ");
                        this.level = Convert.ToInt32(Console.ReadLine());
                    }
                }catch(System.Exception e)
                {
                        Console.Write("Input a number from 1 to 10 : ");
                        while (level < 1 || level > 9)
                    {
                        Console.WriteLine("Entered the wrong level ");
                        Console.Write("Kindly Reenter Level; ");
                        this.level = Convert.ToInt32(Console.ReadLine());
                    }
                }


                switch (level)
                {
                    case 1:
                        Console.WriteLine("Fees for Level 1 is " + FeesLevel1);
                        Console.Write("Fees paying :");
                        try
                        {
                            feesPaying = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (System.Exception e)
                        {
                            Console.Write("Enter amount in digits : ");
                            feeBalance = Convert.ToDouble(Console.ReadLine());

                            
                        }
                        
                            while (feesPaying > FeesLevel1)
                            {
                                Console.WriteLine("Fees paying must be less than " + FeesLevel1);
                                Console.Write("Kingly reenter fee paying :");
                                try
                                {
                                    feesPaying = Convert.ToDouble(Console.ReadLine());
                                }
                                catch (System.Exception e)
                                {
                                    Console.Write("Enter amount in digits : ");
                                    feeBalance = Convert.ToDouble(Console.ReadLine());
                                }
                                
                            }
                        feeBalance = FeesLevel1 - feesPaying;
                        break;
                    case 2:
                        Console.WriteLine("Fees for Level 2  is " + FeesLevel2);
                        Console.Write("Fees paying :");
                        try
                        {
                            feesPaying = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (System.Exception e)
                        {
                            Console.Write("Enter amount in digits : ");
                            feeBalance = Convert.ToDouble(Console.ReadLine());

                            
                        }
                        
                            while (feesPaying > FeesLevel2)
                            {
                                Console.WriteLine("Fees paying must be less than " + FeesLevel2);
                                Console.Write("Kingly reenter fee paying :");
                                try
                                {
                                    feesPaying = Convert.ToDouble(Console.ReadLine());
                                }
                                catch (System.Exception e)
                                {
                                    Console.Write("Enter amount in digits : ");
                                    feeBalance = Convert.ToDouble(Console.ReadLine());

                                    
                                }
                            }
                        feeBalance = FeesLevel2 - feesPaying;
                        break;
                    case 3:
                        Console.WriteLine("Fees for Level 3 is " + FeesLevel3);
                        Console.Write("Fees paying :");
                        try
                        {
                            feesPaying = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (System.Exception e)
                        {
                            Console.Write("Enter amount in digits : ");
                            feeBalance = Convert.ToDouble(Console.ReadLine());

                            
                        }
                        
                            while (feesPaying > FeesLevel3)
                            {
                                Console.WriteLine("Fees paying must be less than " + FeesLevel3);
                                Console.Write("Kingly reenter fee paying :");
                                try
                                {
                                    feesPaying = Convert.ToDouble(Console.ReadLine());
                                }
                                catch (System.Exception e)
                                {
                                    Console.Write("Enter amount in digits : ");
                                    feeBalance = Convert.ToDouble(Console.ReadLine());

                                    
                                }
                            }
                        feeBalance = FeesLevel3 - feesPaying;
                        break;
                    case 4:
                        Console.WriteLine("Fees for Level 4 is " + FeesLevel4);
                        Console.Write("Fees paying :");
                        try
                        {
                            feesPaying = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (System.Exception e)
                        {
                            Console.Write("Enter amount in digits : ");
                            feeBalance = Convert.ToDouble(Console.ReadLine());
                        }
                        
                            while (feesPaying > FeesLevel4)
                            {
                                Console.WriteLine("Fees paying must be less than " + FeesLevel4);
                                Console.Write("Kingly reenter fee paying :");
                                try
                                {
                                    feesPaying = Convert.ToDouble(Console.ReadLine());
                                }
                                catch (System.Exception e)
                                {
                                    Console.Write("Enter amount in digits : ");
                                    feeBalance = Convert.ToDouble(Console.ReadLine());
                                }
                            }
                        feeBalance = FeesLevel4 - feesPaying;
                        break;
                    case 5:
                        Console.WriteLine("Fees for Level 5 is " + FeesLevel5);
                        Console.Write("Fees paying :");
                        try
                        {
                            feesPaying = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (System.Exception e)
                        {
                            Console.Write("Enter amount in digits : ");
                            feeBalance = Convert.ToDouble(Console.ReadLine());

                        }
                        
                            while (feesPaying > FeesLevel5)
                            {
                                Console.WriteLine("Fees paying must be less than " + FeesLevel5);
                                Console.Write("Kingly reenter fee paying :");
                                try
                                {
                                    feesPaying = Convert.ToDouble(Console.ReadLine());
                                }
                                catch (System.Exception e)
                                {
                                    Console.Write("Enter amount in digits : ");
                                    feeBalance = Convert.ToDouble(Console.ReadLine());
                                    
                                }
                            }
                        feeBalance = FeesLevel5 - feesPaying;
                        break;
                    case 6:
                        Console.WriteLine("Fees for Level 6 is " + FeesLevel6);
                        Console.Write("Fees paying :");
                        try
                        {
                            feesPaying = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (System.Exception e)
                        {
                            Console.Write("Enter amount in digits : ");
                            feeBalance = Convert.ToDouble(Console.ReadLine());
                        }
                        
                            while (feesPaying > FeesLevel6)
                            {
                                Console.WriteLine("Fees paying must be less than " + FeesLevel6);
                                Console.Write("Kingly reenter fee paying :");
                                try
                                {
                                    feesPaying = Convert.ToDouble(Console.ReadLine());
                                }
                                catch (System.Exception e)
                                {
                                    Console.Write("Enter amount in digits : ");
                                    feeBalance = Convert.ToDouble(Console.ReadLine());
                                }
                            }
                        feeBalance = FeesLevel6 - feesPaying;
                        break;
                    case 7:
                        Console.WriteLine("Fees for Level 7 is " + FeesLevel7);
                        Console.Write("Fees paying :");
                        try
                        {
                            feesPaying = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (System.Exception e)
                        {
                            Console.Write("Enter amount in digits : ");
                            feeBalance = Convert.ToDouble(Console.ReadLine());

                            
                        }
                        
                            while (feesPaying > FeesLevel7)
                            {
                                Console.WriteLine("Fees paying must be less than " + FeesLevel7);
                                Console.Write("Kingly reenter fee paying :");
                                try
                                {
                                    feesPaying = Convert.ToDouble(Console.ReadLine());
                                }
                                catch (System.Exception e)
                                {
                                    Console.Write("Enter amount in digits : ");
                                    feeBalance = Convert.ToDouble(Console.ReadLine());
                                }
                            }
                        feeBalance = FeesLevel7 - feesPaying;
                        break;
                    case 8:
                        Console.WriteLine("Fees for Level 8 is " + FeesLevel8);
                        Console.Write("Fees paying :");
                        try
                        {
                            feesPaying = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (System.Exception e)
                        {
                            Console.Write("Enter amount in digits : ");
                            feeBalance = Convert.ToDouble(Console.ReadLine());feesPaying = Convert.ToDouble(Console.ReadLine());
                            
                        }
                            {
                                Console.WriteLine("Fees paying must be less than " + FeesLevel8);
                                Console.Write("Kingly reenter fee paying :");
                                try
                                {
                                    feesPaying = Convert.ToDouble(Console.ReadLine());
                                }
                                catch (System.Exception e)
                                {
                                    Console.Write("Enter amount in digits : ");
                                    feeBalance = Convert.ToDouble(Console.ReadLine());
                                }
                            }
                        feeBalance = FeesLevel8 - feesPaying;
                        break;
                    case 9:
                        Console.WriteLine("Fees for Level 9 is " + FeesLevel9);
                        Console.Write("Fees paying :");
                        try
                        {
                            feesPaying = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (System.Exception e)
                        {
                            Console.Write("Enter amount in digits : ");
                            feeBalance = Convert.ToDouble(Console.ReadLine());

                        }
                        
                            while (feesPaying > FeesLevel9)
                            {
                                Console.WriteLine("Fees paying must be less or equal to " + FeesLevel9);
                                Console.Write("Kingly reenter fee paying :");
                                try
                                {
                                    feesPaying = Convert.ToDouble(Console.ReadLine());
                                }
                                catch (System.Exception e)
                                {
                                    Console.Write("Enter amount in digits : ");
                                    feeBalance = Convert.ToDouble(Console.ReadLine());
                                }
                            }
                        feeBalance = FeesLevel9 - feesPaying;
                        break;
                }
                
            this.nowDate = DateTime.Now;  
            Console.WriteLine(this.nowDate); 


            StoreData();
            Console.WriteLine("\t\t\t\tData Successfully Sent TO Server");
        }//end of TakeREgDetails


        public void displayRegDetails(){
            Console.WriteLine("==========================================================================================");
            Console.WriteLine("\t\t\t\tStudent Information");
            Console.WriteLine("==========================================================================================");
            Console.WriteLine("Student Name : {0} {1} {2}",this.StudentFirstName,this.StudentMiddleName,this.StudentLastName);
            Console.WriteLine("Fee Balance :" + this.feeBalance);
            Console.WriteLine("Married : " + this.Married);
            Console.WriteLine("Date and Time of registration : " +  this.nowDate);
            Console.WriteLine("Email : " + this.email);
        }

        public async void StoreData(){
        string path = "MOGISDB.txt";
        string Data = $"{this.StudentFirstName,5} {this.StudentMiddleName,5} {this.StudentLastName,10} Married : {this.Married,10}  Fee Balance: {this.feeBalance,10}  Email: {this.email,10} Date Of Registration : {this.nowDate,10} \n";
        File.AppendAllText(path, Data);
        }

        public static void MultTable(){
            int MultNo;
                Console.Write("Number of Time Table : ");
                MultNo = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= 20; i++)
                {  
                    int calc = MultNo * i;
                    Console.WriteLine(MultNo +" * " + i +" = " + calc);
                }

        }
    }
}



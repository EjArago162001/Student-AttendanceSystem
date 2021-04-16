using System;

namespace StudentEnrollmentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Students Enrollment System");

            string TeachersNumber = "2020-00390-BN-0"; //declare + assignment
            string TeachersName = "Emmanuel Jo G. Arago";
            string TeachersAdress = "Dela Paz Biñan City, Laguna";
            int age = 19;
            string password = "Ej";
            string course = "DICT";
            string yearlevel = "1st";

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter Password:");
                string passwordInput = Console.ReadLine();

                Console.WriteLine();
                if (passwordInput == password)
                {
                    Console.WriteLine("TEACHER'S INFORMATION");
                    Console.WriteLine("Teachers Number: " + TeachersNumber);
                    Console.WriteLine("Teachers Name: " + TeachersName);
                    Console.WriteLine("Teachers Address: " + TeachersAdress);
                    Console.WriteLine("Teachers: " + age);
                    Console.WriteLine("Teachers Coure & Year: " + course + " " + yearlevel);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Password.");
                }
            }

           

            //student selected
           
            Console.WriteLine();
            Console.WriteLine("Numbers of days of present and absences.");


           



    //OUTPUT ALL SELECTED STUDENT'S ATTENDANCE
    Console.WriteLine();
            Console.WriteLine("Emmanuel Jo G. Arago (ATTENDANCE):");

            int student1 = 1;
            switch (student1)
            {
                case 1:
                    Console.WriteLine("(March, 25 present / 5 absences)");
                    Console.WriteLine("(April, 30 present / 0 absences)");
                    Console.WriteLine("(May, 15 present / 10 absences)");
                    break;


                  
                    }
                            }
                    }
}

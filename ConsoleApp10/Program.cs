using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! You have the following Options: \n" +
                              "Press 1 to List all students \n" + "Press 2 to list all Courses");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Command.ListStudents();
                    Console.WriteLine("What do you want to do next? \n");
                    break;
                case "2":
                    Command.ListCourses();
                    Console.WriteLine("What do you want to do next? \n");
                    var coursechoice = Console.ReadLine();
                    break;
                
            }

            Console.ReadLine();
        }
    }
}

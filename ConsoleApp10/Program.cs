using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! You have the following Options: \n" +
                              "Press 1 to List all students \n" + "Press 2 to list all Courses \n" + "Press 3 to Search for student using AU_ID \n" + "Press 4 to list student and teachers assigned to a give Course \n" + "Press 5\n" + "Press 6\n");
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
                    break;
                case "3":
                    Console.WriteLine("Write AU_Id: ");
                    var studentID = Convert.ToInt32(Console.ReadLine());
                    Command.ListStudentCourses(studentID);
                    break;
                case "4":
                    Console.WriteLine("Write Course_Id: ");
                    var courseID = Convert.ToInt32(Console.ReadLine());
                    Command.ListAssignedToCourse(courseID);
                    break;
                case "5":
                    Console.WriteLine("Write Course_Id");
                    var _courseID = Convert.ToInt32(Console.ReadLine());
                    Command.ListCourseContent(_courseID);
                    break;
                case "6":
                    Console.WriteLine("Write student AU_Id & course_Id");
                    var _studentID = Convert.ToInt32(Console.ReadLine());
                    var studentcourseID = Convert.ToInt32(Console.ReadLine());
                    Command.ListStudentAssignments(_studentID, studentcourseID);
                    break;
                
            }

            //while (true) ;
            Console.ReadLine();

        }
    }
}

using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Hello! You have the following Options: \n" +
                              "Press 1 to List all students \n"
                              + "Press 2 to list all Courses \n"
                              + "Press 3 to Search for student using AU_ID \n"
                              + "Press 4 to list student and teachers assigned to a give Course \n"
                              + "Press 5 to List Course Content\n"
                              + "Press 6 to List Student Assignment\n"
                              + "Press 7 to Add Student \n"
                              + "Press 8 to Add Course\n"
                              + "Press 9 to Enroll a new student in Course \n"
                              + "Press 10 to Add assignemnt \n"
                              + "Press 11 to Grade an already existing assignment");
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
                        Console.WriteLine("Write student AU_Id");
                        var _studentID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Write CourseId");
                        var studentcourseID = Convert.ToInt32(Console.ReadLine());
                        Command.ListStudentAssignments(_studentID, studentcourseID);
                        break;
                    case "7":
                        Command.AddStudent();
                        break;
                    case "8":
                        Command.addCourse();
                        break;
                    case "9":
                        Command.Enrollstudent();
                        break;
                    case "10":
                        Command.AddAssignment();
                        break;
                    case "11":
                        Command.GradeAssignment();
                        break;


                }

            } while (true);
            

            


                
                

        }
    }
}

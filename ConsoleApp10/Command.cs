using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp10
{
    public static class Command
    {
        public static async void ListStudents()
        {
            using (var db = new AppDbContext())
            {
                var students = await db.Students.ToListAsync();
                Console.WriteLine("All Student List: \n");
                foreach (var student in students)
                {
                    Console.WriteLine("Name: {0} has AU-Id: {1} \n", student.Name, student.AU_ID);
                }
            }
        }

        public static async void ListCourses()
        {
            using (var db = new AppDbContext())
            {
                var Courses = await db.Course.ToListAsync();
                Console.WriteLine("List of Courses: \n");
                foreach (var course in Courses)
                {
                    Console.WriteLine("Course with Course-Id found: {0} with name: {1} \n", course.Course_id, course.Name);
                }
            }
        }

        public static async void ListStudentCourses(int studentId)
        {
            using (var db = new AppDbContext())
            {
                var studentCourses = await db.CourseEnrolledStudents.Where(s=>s.AU_id==studentId).ToListAsync();
                Console.WriteLine("List of courses for students: \n");
                foreach (var course in studentCourses)
                {
                    Console.WriteLine("Course with Course-Id found: {0}", course._Course.Name);
                    Console.WriteLine("Status: {0}", course._Course.Status);
                    Console.WriteLine("Grade for student: {0} \n", course.Grade);
                }
            }
        }

        public static async void ListAssignedToCourse(int courseId)
        {
            using (var db = new AppDbContext())
            {
                var courseStudents = await db.CourseEnrolledStudents.Where(c => c.Course_id == courseId).ToListAsync();
                var courseTeachers = await db.CourseTeacher.Where(c => c.Course_id == courseId).ToListAsync();
                Console.WriteLine("List of assigned students and teachers to course: \n");
                foreach (var student in courseStudents)
                {
                    Console.WriteLine("Student name: {0}", student._Students.Name);
                }

                foreach (var teacher in courseTeachers)
                {
                    Console.WriteLine("\nTeacher name: {0}", teacher.Teacher.Name);
                }
            }
        }

        public static async void ListCourseContent(int courseId)
        {
            using (var db = new AppDbContext())
            {
                var courseContents = await db.CourseContents.Where(c => c.Course_id == courseId).ToListAsync();
                Console.WriteLine("List of content to course: \n");
                foreach (var courseContent in courseContents)
                {
                    Console.WriteLine("Course content: {0}", courseContent.Content.Content_Id);
                }
            }
        }

        public static async void ListStudentAssignments(int studentId,int courseId)
        {
            using (var db = new AppDbContext())
            {
                var studentsAssignments = await db.CourseEnrolledStudents.Where(c => c.Course_id == courseId && c.AU_id == courseId).ToListAsync();
                Console.WriteLine("List of content to course: \n");
                foreach (var student in studentsAssignments)
                {
                    foreach (var assignment in student._Course.CourseAssignments)
                    {
                        Console.WriteLine("Assignment id: {0}", assignment.Assignment.Assignment_Id);
                        Console.WriteLine("Grade: {0}", assignment.Assignment.Grades);
                        Console.WriteLine("Graded by: {0} \n", assignment.Assignment.Teacher.Name);
                    }
                    
                }
            }
        }

        public static void AddStudent()
        {
            

            Console.WriteLine("Enter Student name: ");
            var AddStudent_Name = Console.ReadLine();

            Console.WriteLine("Enter Birthday: ");
            var AddStudent_Birthday = DateTime.Parse(Console.ReadLine());

            
            Console.WriteLine("groupid: ");
            var groupid = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Groupsize");
            var size = Convert.ToUInt32(Console.ReadLine());

            var student = new Students()
            {
                Name = AddStudent_Name,
                Birthday = AddStudent_Birthday,
                Group_id = groupid
                
            };
            var group = new Group()
            {
                
                GroupSize = size
            };

            using (var db = new AppDbContext())
            {
                db.Group.Add(group);
                db.Students.Add(student);
                
                db.Database.OpenConnection();


                try
                {
                    db.SaveChanges();
                }
                finally
                {
                    db.Database.CloseConnection();
                    Console.WriteLine("Done");
                }


            }

        }

        public static void addCourse()
        {
            
            Console.WriteLine("Write name: ");
            var coursename = Console.ReadLine();

            Console.WriteLine("Write Course activity true or false");
            var coursestatus = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Write Calendar_id");
            var Calendarids = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write Courselecture");
            var Courselec = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Write Handin");
            var Handin = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Write Deadlines");
            var Deadlines = Convert.ToDateTime(Console.ReadLine());



            var course = new Course()
            {
                Name = coursename,
                Status = coursestatus,
                Calendar_id = Calendarids
            };

            var calendar = new Calendar()
            {
                CourseLecture = Courselec,
                Handin = Handin,
                Deadlines = Deadlines
            };



            using (var db = new AppDbContext())
            {
                db.Course.Add(course);
                db.Calendar.Add(calendar);
                
                db.Database.OpenConnection();


                try
                {
                    db.SaveChanges();
                }
                finally
                {
                    db.Database.CloseConnection();
                    Console.WriteLine("Done");
                }


            }



        }

        public static void Enrollstudent()
        {

            Console.WriteLine("What is the students AU_Id?: ");
            var studentid = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("What course do you want the student to join?");
            var courseid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Enrolldate");
            var enrolldate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter Graduation date");
            var Graduationdate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Write Grade: ");
            var grade = Convert.ToInt32(Console.ReadLine());

            using (var db = new AppDbContext())
            {
                var enrollstudent = new CourseEnrolledStudents()
                {
                    Course_id = courseid,
                    AU_id = studentid,
                    EnrolledDate = enrolldate,
                    GraduationDate = Graduationdate,
                    Grade = grade
                    
                };
                db.CourseEnrolledStudents.Add(enrollstudent);

                var students = db.Students.Single(a => a.AU_ID.Equals(studentid));
                var course = db.Course.Single(c => c.Course_id.Equals(courseid));

                students.CourseEnrolledStudents.Add(enrollstudent);
                course.CourseEnrolledStudents.Add(enrollstudent);

                db.SaveChanges();

                    
            }
        }


        // This is a test, not required
        public static async void showstudentsgroup()
        {
            using (var db = new AppDbContext())
            {
                var groupList = await db.Group
                    .Include(v => v._Students)
                    .SingleAsync(g => g.GroupID.Equals(1));
                Console.WriteLine("All Student List: \n");
                foreach (var student in groupList._Students)
                {
                    Console.WriteLine("{0}", student.Name);
                    
                }
            }
        }

        public static void AddAssignment()
        {
            // Console.WriteLine("Write the assignment you want to add: ");
            // var assignmentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Is the grading done by an assistant-teacher? ");
            var assistant = Console.ReadLine();

            Console.WriteLine("Write the AU_ID of the teacher, responsible for grading");
            var auId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter hand in date: ");
            var handinDate = DateTime.Parse(Console.ReadLine());

            var assignment = new Assignment
            {
                HandInDate = handinDate
            };

            if (assistant.ToUpper() == "YES")
            {
                assignment.AU_Id_Assistant = auId;
            }

            else
            {
                assignment.AU_ID = auId;
            }

            using (var db = new AppDbContext())
            {
                db.Assignment.Add(assignment);

                db.Database.OpenConnection();

                try
                {
                    Console.WriteLine("linje318");
                    db.SaveChanges();
                }
                finally
                {
                    db.Database.CloseConnection();
                    Console.WriteLine("Done");
                }
            }
        }

        public static void GradeAssignment()
        {
            
            

            

            using (var db = new AppDbContext())
            {

                var assignmentiids = db.Assignment.ToList();

                foreach (var assignment in assignmentiids)
                {
                    Console.WriteLine("Assignemnt Id: {0}", assignment.Assignment_Id);
                    
                }
                
                
                
                Console.WriteLine("indtast ID for opgaven");
                var id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("indtast karakteren");
                var karakter = Convert.ToInt32(Console.ReadLine());
                //Trækker pågældende assignment ud
                var entity = db.Assignment.FirstOrDefault(item => item.Assignment_Id == id);
                if (entity != null) 
                {
                    //ændrer karakteren
                    entity.Grades = karakter;                  
                }
                //save changes
                db.SaveChanges();
                
            }

        }
    }
}

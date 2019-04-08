using System;
using System.Collections.Generic;
using System.Linq;
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
                    Console.WriteLine("Course with Course-Id found: {0} \n", course.Course_id);
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
    }
}

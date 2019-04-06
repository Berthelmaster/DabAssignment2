using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp10
{
    public class Command
    {
        public async void ListStudents()
        {
            using (var db = new AppDbContext())
            {
                var students = await db.Studentss.ToListAsync();
                Console.WriteLine("All Student List: \n");
                foreach (var student in students)
                {
                    Console.WriteLine("Name: {0} has AU-Id: {1} \n", student.Name, student.AU_ID);
                }
            }
        }

        public async void ListCourses()
        {
            using (var db = new AppDbContext())
            {
                var Courses = await db.Courses.ToListAsync();
                Console.WriteLine("List of Courses: \n");
                foreach (var course in Courses)
                {
                    Console.WriteLine("Course with Course-Id found: {0} \n", course.Course_id);
                }
            }
        }
    }
}

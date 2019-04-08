using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace ConsoleApp10
{
    public class Course
    {
        [Key]
        public int Course_id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public List<CourseEnrolledStudents> CourseEnrolledStudents { get; set; }
        public int Calendar_id { get; set; }
        public Calendar Calendar { get; set; }
        public List<CourseContent> CourseContents { get; set; }
        public List<CourseAssignment> CourseAssignments { get; set; }
        public List <CourseGroup> CourseGroups { get; set; }
        public List<CourseTeacher> CourseTeachers { get; set; }
    }
}
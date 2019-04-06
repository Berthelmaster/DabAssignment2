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
        public bool Status { get; set; }
        public List<CourseEnrolledStudents> CourseEnrolledStudents { get; set; }

    }
}
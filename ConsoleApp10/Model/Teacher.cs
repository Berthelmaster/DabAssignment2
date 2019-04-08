using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace ConsoleApp10
{
    public class Teacher
    {
        [Key]
        public int AU_ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public List<Assignment> Assignments { get; set; }
        public List<CourseTeacher> CourseTeachers { get; set; }
    }
}
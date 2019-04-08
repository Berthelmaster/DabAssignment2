using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace ConsoleApp10
{
    public class CourseTeacher
    {
        public int AU_id { get; set; }
        public int Course_id { get; set; }
        public Teacher Teacher { get; set; }
        public Course Course { get; set; }
    }
}
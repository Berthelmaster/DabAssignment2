using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace ConsoleApp10
{
    public class CourseAssignment
    {
        public int Course_id { get; set; }
        public int Assignment_id { get; set; }
        public Course Course { get; set; }
        public Assignment Assignment { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace ConsoleApp10
{
    public class Calendar
    {
        [Key]
        public int Calendar_id { get; set; }
        public DateTime CourseLecture{ get; set; }
        public DateTime Handin { get; set; }
        public DateTime Deadlines { get; set; }
        public List<Course> Courses { get; set; }
       

    }
}
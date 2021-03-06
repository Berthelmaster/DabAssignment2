using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace ConsoleApp10
{
    public class Students
    {
        [Key]
        public int AU_ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public Group Group { get; set; }
        public int Group_id { get; set; }
        public List<CourseEnrolledStudents> CourseEnrolledStudents { get; set; }
    }
}
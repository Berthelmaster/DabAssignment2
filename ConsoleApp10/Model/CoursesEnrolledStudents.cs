using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace ConsoleApp10
{
    public class CourseEnrolledStudents
    {
        public int Course_id { get; set; }
        public Course _Course { get; set; }
        public int AU_id { get; set; }
        public Students _Students { get; set; }
        public DateTime EnrolledDate { get; set; }
        public DateTime GraduationDate { get; set; }

    }
}
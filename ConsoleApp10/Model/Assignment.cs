using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace ConsoleApp10
{
    public class Assignment
    {
        [Key]
        public int Assignment_Id { get; set; }
        public DateTime HandInDate { get; set; }
        public int Grades { get; set; } 

        public Teacher Teacher { get; set; }
        public int AU_ID { get; set; }
        public AssistantTeacher AssistentTeacher{ get; set; }
        public int AU_Id { get; set; }
        public List<CourseAssignment> CourseAssignments { get; set; }
        public List<GroupAssignment> GroupAssignment { get; set; }
    }
}
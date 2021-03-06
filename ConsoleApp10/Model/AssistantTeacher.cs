using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace ConsoleApp10
{
    public class AssistantTeacher
    {
        [Key]
        public int AU_ID{ get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public List<Assignment> Assignments_ { get; set; }
    }
}
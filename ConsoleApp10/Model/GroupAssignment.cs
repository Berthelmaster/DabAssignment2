using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace ConsoleApp10
{
    public class GroupAssignment
    {
        public int GroupID { get; set; }
        public Group Group { get; set; }
        public int Assignment_ID { get; set; }
        public Assignment Assignment { get; set; }
    }
}
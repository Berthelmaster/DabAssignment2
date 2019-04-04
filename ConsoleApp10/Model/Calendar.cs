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
        public int AU_id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

    }
}
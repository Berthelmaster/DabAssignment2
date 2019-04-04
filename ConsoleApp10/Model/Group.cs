using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace ConsoleApp10
{
    public class Group
    {
        [Key]
        public int GroupID { get; set; }
           
        public uint GroupSize{ get; set; }

        public List<Students> _Students { get; set; }

    }
}
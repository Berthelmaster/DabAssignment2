using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace ConsoleApp10
{
    public class Content
    {
        [Key]
        public int Content_Id { get; set; }
        [ForeignKey()]

    }
}
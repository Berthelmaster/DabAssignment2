using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace ConsoleApp10
{
    public class Audio
    {
        [Key]
        public int Audio_id { get; set; }
        
        public int Area_Id { get; set; }
        public ContentArea ContentArea_Id { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace ConsoleApp10
{
    public class TextBlock
    {
        [Key]
        public int TextBlock_id { get; set; }

        [ForeignKey("ContentArea_Id")]
        public int Area_Id { get; set; }
        public ContentArea ContentArea_Id { get; set; }
    }
}
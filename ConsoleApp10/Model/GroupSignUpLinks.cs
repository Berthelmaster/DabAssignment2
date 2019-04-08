using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace ConsoleApp10
{
    public class GroupSignUpLink
    {
        [Key]
        public int GSUL_id { get; set; }

        public int Area_Id { get; set; }
        public ContentArea ContentArea_Id { get; set; }
    }
}
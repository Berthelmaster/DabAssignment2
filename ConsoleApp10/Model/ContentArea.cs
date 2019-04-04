using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace ConsoleApp10
{
    public class ContentArea
    {
        [Key]
        public int Area_Id{ get; set; }

        [ForeignKey("Content")]
        public int Content_Id { get; set; }
        public Content Content{ get; set; }

        [ForeignKey("ContentFolder")]
        public int Folder_Id { get; set; }
        public ContentFolder Folder { get; set; }
    }
}
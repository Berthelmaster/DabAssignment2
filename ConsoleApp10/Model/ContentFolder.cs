using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace ConsoleApp10
{
    public class ContentFolder
    {
        public int Folder_id { get; set; }

        [ForeignKey("Content")]
        public int Content_id { get; set; }
        public Content Content { get; set; }
    }
}
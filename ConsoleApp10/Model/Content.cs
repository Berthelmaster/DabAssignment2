using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace ConsoleApp10
{
    public class Content
    {
        // Missing courses id
        [Key]
        public int Content_Id { get; set; }

        public List<CourseContent> CourseContents { get; set; }

        public List<ContentArea> ContentAreas { get; set; }

        //public List<ContentFolder> ContentFolders { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace ConsoleApp10
{
    public class CourseContent
    {

        public int Course_id { get; set; }
        public Course Course { get; set; }
        public int Content_id { get; set; }
        public Content Content { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorProject.Models
{
    public class ProjectEvaluation
    {
        public string name { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public double rating { get; set; }

        public int id { get; set; }
    }
}
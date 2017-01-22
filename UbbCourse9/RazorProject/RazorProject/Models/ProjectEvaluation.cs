using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;

namespace RazorProject.Models
{
    [Bind(Exclude = "country")]
    public class ProjectEvaluation
    {
        [Required]
        [StringLength(1000)]
        [DisplayName("nume")]
        public string name { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        [Range(1, 10)]
        [Required]
        public double rating { get; set; }

        public int id { get; set; }
    }
}
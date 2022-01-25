using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace simpleBlogsite.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Blog Category")]
        public string Category { get; set; }
        [Required]
        [Display(Name = "Blog Title")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Blog Description")]
        public String Description { get; set; }
        [Required]
        [Display(Name = "Blog URL")]
        public string URl { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using RaccoonBlog.Web.Helpers.Validation;
using System;

namespace RaccoonBlog.Web.Models
{
    /*Section can contains:
	 * 1. Body = "Any html text"
	 * 2. Can point to any internal action.
	 */
    public class Series : Model
    {
        [Display(Name = "Slug")]
        public string Slug { get; set; }
        [Display(Name = "PublishAt")]
        public DateTimeOffset PublishAt { get; set; }
        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }
    }
}
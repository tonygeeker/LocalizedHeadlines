using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWebApplication.Models
{
    public class ArticleViewModel
    {
        public ArticleSource Source { get; set; }
        public string  Author { get; set; }
        public string  Title { get; set; }
        public string  Description { get; set; }
        public string  Url { get; set; }
        [DisplayName("Image URL")]
        public string  UrlToImage { get; set; }
        [DisplayName("Publish Date")]
        public string  PlublishDate { get; set; }
        public string  Content { get; set; }
    }
}
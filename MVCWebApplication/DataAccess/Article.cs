using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebApplication.DataAccess
{
    public class Article
    {
        public int ArticleId { get; set; }
        public string Source { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string UrlToImage { get; set; }
        public string PlublishDate { get; set; }
        public string Content { get; set; }

        public virtual ApplicationUserManager User { get; set; }
    }
}
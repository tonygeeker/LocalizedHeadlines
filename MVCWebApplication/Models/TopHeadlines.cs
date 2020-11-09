using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebApplication.Models
{
    public class TopHeadlines
    {
        public List<NewsAPI.Models.Article> Articles { get; set; }
    }
}
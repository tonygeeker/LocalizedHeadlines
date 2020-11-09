using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebApplication.Models
{
    public class NewsResultsModel
    {
        public string Status { get; set; }
        public int TotalResults { get; set; }
        public List<ArticleViewModel> Articles { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebApplication.DataAccess
{
    public class UserInput
    {
        public int UserInputId { get; set; }
        public string Location { get; set; }

        public virtual ApplicationUserManager ApplicationUser { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}
using MVCWebApplication.Models;
using NewsAPI;
using NewsAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public async Task<ActionResult> GetHeadlines(NewsAPI.Constants.Countries country)
        {
            string apiKey = ConfigurationManager.AppSettings["NewsApiKey"];
            var headlines = new TopHeadlines();
            var path = $"http://newsapi.org/v2/top-headlines?country=us&apiKey={apiKey}";

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(path);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    headlines = JsonConvert.DeserializeObject<TopHeadlines>(jsonString);
                }
            }

            return View(headlines.Articles);
        }
    }
}
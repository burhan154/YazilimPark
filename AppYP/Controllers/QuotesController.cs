using AppYP.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AppYP.Controllers
{
    public class QuotesController : Controller
    {

        public QuoteModel NewQuote()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string json = (new WebClient()).DownloadString("https://gist.githubusercontent.com/nasrulhazim/54b659e43b1035215cd0ba1d4577ee80/raw/e3c6895ce42069f0ee7e991229064f167fe8ccdc/quotes.json");
            QuotesModel quotes = JsonConvert.DeserializeObject<QuotesModel>(json);

            Random rand = new Random();
            int val = rand.Next(quotes.quotes.Count - 1);

            return quotes.quotes[val];
        }
        public IActionResult Index()
        {
            return View(NewQuote());
        }

        [HttpPost]
        public JsonResult GetNewQuote()
        {
            return Json(NewQuote());
        }
    }
}

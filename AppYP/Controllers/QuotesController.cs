using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Entity.Concrete;
using DataAccess.Concrete;

namespace AppYP.Controllers
{
    public class QuotesController : Controller
    {
        QuotesRepository quotesRepository = new QuotesRepository();
        public IActionResult Index()
        {
            return View(quotesRepository.GetRandom());
        }

        [HttpPost]
        public JsonResult GetNewQuote()
        {
            return Json(quotesRepository.GetRandom());
        }
    }
}

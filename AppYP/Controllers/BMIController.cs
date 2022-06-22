using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Concrete;

namespace AppYP.Controllers
{

    public class BMIController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GetBMI(BMIModel bmi)
        {

            if (ModelState.IsValid)
            {
                double Weight = bmi.Weight;
                double Height = bmi.Height;
                if (bmi.Weight <= 1 || bmi.Weight <= 1)
                {
                    ViewBag.data = 0;
                    return Json(new { result = 0, message = "Lower than 1" });
                }
                double result = (Height * Height) / 10000;
                result = Weight / result;
                result = Math.Round(result, 2);
                string message;

                if (result > 30)
                    message = "obese";
                else if (result > 25)
                    message = "over weight";
                else if (result > 18.5)
                    message = "normal";
                else
                    message = "under weight";

                return Json(new { result = result, message = message });

                }
            return Json(new { result = 0, message = "invalid" });

        }
    }
}

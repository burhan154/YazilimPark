using AppYP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public ActionResult Details(int id)
        {
        return View();
        }

        // GET: BMIController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BMIController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BMIController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BMIController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BMIController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BMIController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

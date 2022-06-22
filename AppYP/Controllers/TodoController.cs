using DataAccess.Concrete;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppYP.Controllers
{
    public class TodoController : Controller
    {

        TodoRepository todoRepository = new TodoRepository();

        public ActionResult Index()
        {
            return View(todoRepository.GetAll());
        }

        [HttpPost]
        public JsonResult Add(string todo)
        {
            return Json(todoRepository.Add(todo));
        }

        [HttpPost]
        public JsonResult Change(int id)
        {
            todoRepository.ChangeChecked(id);
            return Json(new { result = 1, message = "changed" });
        }

        [HttpPost]
        public JsonResult Delete(int id)
        {
            todoRepository.Delete(id);
            return Json(new { result = 1, message = "deleted" });
        }
    }
}

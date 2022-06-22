using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppYP.Components
{
    public class Navbar:ViewComponent
    {
        AppRepository appRepository = new AppRepository();

        public IViewComponentResult Invoke()
        {
            return View(appRepository.GetAll());
        }
    }
}

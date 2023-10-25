using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemplatedHTMLHelper.Models;

namespace TemplatedHTMLHelper.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee employee = new Employee()
            {
                Id = 1,
                Name="Vinay",
                Email="vinay@gmail.com",
                isOnline=true,
                DateOfBirth=DateTime.Now

            };
            return View(employee);
        }
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            return View(employee);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWithEFCF3.Models;

namespace MVCWithEFCF3.Controllers
{
    public class SchoolController : Controller
    {
        SchoolDBContext dc = new SchoolDBContext();
        public ActionResult Index()
        {
            Student s = new Student { Name = "Raju" };
            dc.Students.Add(s);
            dc.SaveChanges();
            return View(dc.Students);
        }
    }
}
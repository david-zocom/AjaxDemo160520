using AjaxDemo160520.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxDemo160520.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {
            SchoolContext context = new SchoolContext();
            int count = context.Students.Count();
            return View();
        }
    }
}
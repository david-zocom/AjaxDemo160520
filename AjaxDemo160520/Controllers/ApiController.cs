using AjaxDemo160520.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxDemo160520.Controllers
{
    public class ApiController : Controller
    {
        // GET: Api
        public ActionResult Index(string searchString)
        {
            SchoolContext context = new SchoolContext();
            var matches = from m in context.Students
                          where m.Name.ToLower().StartsWith(searchString.ToLower())
                          select m;
            if (matches.Count() > 0)
                return Json(matches.First(), JsonRequestBehavior.AllowGet);
            else
                return Json("No matches found", JsonRequestBehavior.AllowGet);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class testController : Controller
    {
        // GET: test
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public FileResult PartialTestView(string ObjectId)
        {
            var res = ObjectId;

            throw new Exception();
            
            //return
        }
    }
}
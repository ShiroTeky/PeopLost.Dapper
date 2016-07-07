using PeopLost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PeopLost.Controllers
{
    public class PeopleController : Controller
    {
        private bd_app_disparueEntities context = new bd_app_disparueEntities();

        // GET: People/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: People/Create
        [HttpPost]
        public ActionResult Create(PeopleViewModel people)
        {
            try
            {
                // TODO: Add insert logic here
                if(!ModelState.IsValid)
                {
                    return View();
                }
                
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

       
    }
}

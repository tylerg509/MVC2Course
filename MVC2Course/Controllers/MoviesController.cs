using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC2Course.Models;

namespace MVC2Course.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            //return View(movie);
            //return Content("hello world");
            //return HttpNotFound();
            //return RedirectToAction("Index","Home", new{ page =1, sortBy = "Name"});
            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            return Content("Id=" + id);
        }
        
        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            
                pageIndex = 1;
            
            if(String.IsNullOrEmpty(sortBy))
            
                sortBy = "Name";
            
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));

                
        }
    }
}
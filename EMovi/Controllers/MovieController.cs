using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EMovi.Models;

namespace EMovi.Controllers
{
    public class MovieController : Controller
    {
        DatabaseEntities _db = new DatabaseEntities();
        // GET: Movie
        public ActionResult Index()
        {
            var model = _db.Movies.ToList();

            return View(model);
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
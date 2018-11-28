﻿using System;
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
            return View();
        }

        public ActionResult Search(string name = null, string genre = null, string year = null)
        {
            var query =
                _db.Movies
                .Where(r => name == null || r.Name.Contains(name));
                

            return View(query);
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
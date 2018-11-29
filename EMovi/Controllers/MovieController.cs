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

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Total(Movie movie) {

            return View(movie);
        }

        [HttpGet]
        public ActionResult Search(string name = null, string genre = null, string year = null)
        {
            if (String.IsNullOrWhiteSpace(year)) year = null;
            if (String.IsNullOrWhiteSpace(name)) name = null;
            if (String.IsNullOrWhiteSpace(genre)) genre = null;            

            var query =
                _db.Movies
                .Where(
                    r =>
                    (name == null || r.Name.Contains(name)) &&
                    (year == null || r.ReleaseDate.Year.ToString().Equals(year)) &&
                    (genre == null || r.Genres.Any(g => g.Name.Equals(genre)))
                );


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
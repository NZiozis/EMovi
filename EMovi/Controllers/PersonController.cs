using EMovi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EMovi.Controllers
{
    public class PersonController : Controller
    {

        DatabaseEntities _db = new DatabaseEntities();
        

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Total(Person person)
        {
            var query = _db.People.Where(p => p.PersonId == person.PersonId);

            return View(query.First());
        }

        public ActionResult Search(string fname = null, string lname = null, string genre = null, string year = null, string typePerson = null)
        {
            if (String.IsNullOrWhiteSpace(year)) year = null;
            if (String.IsNullOrWhiteSpace(fname)) fname = null;
            if (String.IsNullOrWhiteSpace(lname)) lname = null;
            if (String.IsNullOrWhiteSpace(genre)) genre = null;
            if (String.IsNullOrWhiteSpace(typePerson)) typePerson = null;

            IQueryable<Person> query = null;

            if (typePerson == null)
            {
                query =
                        _db.People
                        .Where(person => (
                           (fname == null || person.FirstName.Contains(fname)) &&
                           (lname == null || person.LastName.Contains(lname)) &&
                           (genre == null || 
                                person.Actors.Any(actor => actor.ActsIns.Any(role => role.Movie.Genres.Any(g => g.Name.Contains(genre)))) ||
                                person.Directors.Any(director => director.Directs.Any(role => role.Movie.Genres.Any(g => g.Name.Contains(genre))))
                                )
                        ));
            }
            else if (typePerson.ToLower().Equals("actor"))
            {
                query =
                        _db.People
                        .Where(person => (
                           (person.Actors.Any(actor => _db.Actors.Any(a => a.ActorId == actor.ActorId ))) &&
                           (fname == null || person.FirstName.Contains(fname)) &&
                           (lname == null || person.LastName.Contains(lname)) &&
                           (genre == null || person.Actors.Any(actor => actor.ActsIns.Any(role => role.Movie.Genres.Any(g => g.Name.Contains(genre)))))
                        ));
            }
            else if (typePerson.ToLower().Equals("director"))
            {
                query =
                    _db.People
                    .Where(person => (
                        (person.Directors.Any(director => _db.Directors.Any(d => d.DirectorID == director.DirectorID))) &&
                        (fname == null || person.FirstName.Contains(fname)) &&
                        (lname == null || person.LastName.Contains(lname)) &&
                        (genre == null || person.Directors.Any(director => director.Directs.Any(role => role.Movie.Genres.Any(g => g.Name.Contains(genre)))))
                    ));
            }
            else if (typePerson.ToLower().Equals("both"))
            {
                query =
                        _db.People
                        .Where(person => (
                           (
                                (person.Directors.Any(director => _db.Directors.Any(d => d.DirectorID == director.DirectorID))) &&
                                (person.Actors.Any(actor => _db.Actors.Any(a => a.ActorId == actor.ActorId)))
                            ) &&

                           (fname == null || person.FirstName.Contains(fname)) &&
                           (lname == null || person.LastName.Contains(lname)) &&
                           (genre == null ||
                                person.Actors.Any(actor => actor.ActsIns.Any(role => role.Movie.Genres.Any(g => g.Name.Contains(genre)))) ||
                                person.Directors.Any(director => director.Directs.Any(role => role.Movie.Genres.Any(g => g.Name.Contains(genre))))
                                )
                        ));
            }

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
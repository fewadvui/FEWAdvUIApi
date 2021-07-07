using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FEWAdvUIApi.Controllers
{
    public class MoviesController : ControllerBase
    {
        [HttpGet("/movies")]
        public ActionResult GetMovies()
        {
            var data = new List<Movie>
            {
                new Movie("2", "Jaws", "Spielberg", 1977),
                new Movie("3", "ET", "Speilberg", 1983),
                new Movie("4", "Husbands", null, 1978),

            };

            return Ok(new { data });
        }
    }

    /*
     *  id: string;
  title: string;
  director: string;
  yearReleased: number;
    */

    public record Movie(string Id, string Title, string Director, int yearReleased);
}

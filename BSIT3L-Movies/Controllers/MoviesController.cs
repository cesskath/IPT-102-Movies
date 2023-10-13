using System;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSIT3L_Movies.Controllers
{
	public class MoviesController : Controller
    {
        private List<MovieViewModel> _movies;
        public MoviesController()
		{
            // Sample movie data
            _movies = new List<MovieViewModel>
            {
                 new MovieViewModel { Id = 1, Name = "Titanic", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama", Cover = "/image/titanic.jpeg" }, //Link = "https://www.youtube.com/watch?v=I7c1etV7D7g"},
            new MovieViewModel { Id = 2, Name = "Inception", Rating = "4", ReleaseYear = 2010, Genre = "Science Fiction/Thriller", Cover = "/image/inception.jpeg"}, //Link = "https://www.youtube.com/watch?v=8hP9D6kZseM"
            new MovieViewModel { Id = 3, Name = "The Shawshank Redemption", Rating = "5", ReleaseYear = 1994, Genre = "Drama", Cover = "/image/shawshank.jpeg" }, //Link = "https://www.youtube.com/watch?v=PLl99DlL6b4"},
            new MovieViewModel { Id = 4, Name = "John Wick", Rating = "5", ReleaseYear = 2014, Genre = "Action/Thriller", Cover = "/image/johnwickmyloves.jpg"},// Link = "https://www.youtube.com/watch?v=2AUmvWm5ZDQ"},
            new MovieViewModel { Id = 5, Name = "Rorouni Kenshin", Rating = "5", ReleaseYear = 2012, Genre = "Drama/Adventure", Cover = "/image/kenshin.jpeg"}, //Link = "https://www.youtube.com/watch?v=f8cFqHeUVMs"},
            new MovieViewModel { Id = 6, Name = "I Am Legend", Rating = "4", ReleaseYear = 2007, Genre = "Drama/Sci-fi", Cover = "/image/legend.jpeg" }, //Link = "https://www.youtube.com/watch?v=sFNPNT_4Qww"},
            new MovieViewModel { Id = 7, Name = "Train to Busan", Rating = "5", ReleaseYear = 2016, Genre = "Drama/Horror", Cover = "/image/busan.jpeg" }, //Link = "https://www.youtube.com/watch?v=pyWuHv2-Abk"},
            new MovieViewModel { Id = 8, Name = "Ballerina", Rating = "4", ReleaseYear = 2023, Genre = "Action", Cover = "/image/ballerina.jpeg" }, //Link = "https://www.youtube.com/watch?v=KTt9Dn_W1aE"},
            new MovieViewModel { Id = 9, Name = "Jujutsu Kaisen 0", Rating = "5", ReleaseYear = 2021, Genre = "Fantasy/Action", Cover = "/image/jujutsu.jpeg" }, //Link = "https://www.youtube.com/watch?v=Pm-wNmS9RGI"},
            new MovieViewModel { Id = 10, Name = "Insidious", Rating = "4", ReleaseYear = 2010, Genre = "Horror", Cover = "/image/insidious.jpeg" }, //Link = "https://www.youtube.com/watch?v=zuZnRUcoWos"},
            new MovieViewModel { Id = 11, Name = "3 Idiots", Rating = "5", ReleaseYear = 2009, Genre = "Drama/Comedy", Cover = "/image/3idiots.jpeg" }, //Link = "https://www.youtube.com/watch?v=xvszmNXdM4w"},
            new MovieViewModel { Id = 12, Name = "Goyo: The Boy General", Rating = "5", ReleaseYear = 2018, Genre = "War/History", Cover = "/image/goyo.jpeg" }, //Link = "https://www.youtube.com/watch?v=tiQnXS6wgdY"},
            new MovieViewModel { Id = 13, Name = "The Hows of Us", Rating = "5", ReleaseYear = 2018, Genre = "Drama/Romance", Cover = "/image/thou.jpeg" }, //Link = "https://www.youtube.com/watch?v=9C5w28q6JgA"},
            new MovieViewModel { Id = 14, Name = "The Equalizer", Rating = "5", ReleaseYear = 2014, Genre = "Action/Thriller", Cover = "/image/equalizer.jpeg" }, //Link = "https://www.youtube.com/watch?v=VjctHUEmutw"},
            new MovieViewModel { Id = 15, Name = "A Man Called Otto", Rating = "5", ReleaseYear = 2022, Genre = "Drama/Comedy", Cover = "/image/a man called otto.jpeg" }, //Link = "https://www.youtube.com/watch?v=eFYUX9l-m5I"}
			};
        }
        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "Avatar", Rating = "5" };
            return View(movie);
        }
        public ActionResult GetMovie(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return View(movie);

        }

    }
}


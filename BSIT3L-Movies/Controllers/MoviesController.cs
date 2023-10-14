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
            new MovieViewModel { Id = 1, Name = "Titanic", Rating = "4.8", ReleaseYear = 1997, Genre = "Drama", Cover = "/image/titanic.jpeg", Link = "https://www.youtube.com/embed/I7c1etV7D7g?si=XGB8dzzX-UVsqq4t"},
            new MovieViewModel { Id = 2, Name = "Inception", Rating = "4.8", ReleaseYear = 2010, Genre = "Science Fiction/Thriller", Cover = "/image/inception.jpeg", Link = "https://www.youtube.com/embed/8hP9D6kZseM?si=Y1uCDRgyyvqd_YRT"},
            new MovieViewModel { Id = 3, Name = "The Shawshank Redemption", Rating = "4.9", ReleaseYear = 1994, Genre = "Drama", Cover = "/image/shawshank.jpeg" , Link = "https://www.youtube.com/embed/PLl99DlL6b4?si=q7JLHgEHFF-55c2L"},
            new MovieViewModel { Id = 4, Name = "John Wick", Rating = "4.6", ReleaseYear = 2014, Genre = "Action", Cover = "/image/johnwickmyloves.jpg", Link = "https://www.youtube.com/embed/2AUmvWm5ZDQ?si=Z1cZ4GXvdDiX5T5m"},
            new MovieViewModel { Id = 5, Name = "Rorouni Kenshin", Rating = "4.8", ReleaseYear = 2012, Genre = "Drama", Cover = "/image/kenshin.jpeg", Link = "https://www.youtube.com/embed/f8cFqHeUVMs?si=0ZxSkRKxT3-4ySSN"},
            new MovieViewModel { Id = 6, Name = "I Am Legend", Rating = "4.4", ReleaseYear = 2007, Genre = "Drama", Cover = "/image/legend.jpeg" , Link = "https://www.youtube.com/embed/sFNPNT_4Qww?si=utyjUKZAlqpUx-WP"},
            new MovieViewModel { Id = 7, Name = "Train to Busan", Rating = "4.9", ReleaseYear = 2016, Genre = "Drama/Horror", Cover = "/image/busan.jpeg" , Link = "https://www.youtube.com/embed/pyWuHv2-Abk?si=fTFfPmnupIAXCOzQ"},
            new MovieViewModel { Id = 8, Name = "Ballerina", Rating = "4.6", ReleaseYear = 2023, Genre = "Action", Cover = "/image/ballerina.jpeg" , Link = "https://www.youtube.com/embed/KTt9Dn_W1aE?si=DW2HCO6yq20exugG"},
            new MovieViewModel { Id = 9, Name = "Jujutsu Kaisen 0", Rating = "4.8", ReleaseYear = 2021, Genre = "Fantasy/Action", Cover = "/image/jujutsu.jpeg" , Link = "https://www.youtube.com/embed/Pm-wNmS9RGI?si=pdlbMbTMVDNw2iE6"},
            new MovieViewModel { Id = 10, Name = "Insidious", Rating = "4.2", ReleaseYear = 2010, Genre = "Horror", Cover = "/image/insidious.jpeg" , Link = "https://www.youtube.com/embed/zuZnRUcoWos?si=tX3QRAtx5hlsEA--"},
            new MovieViewModel { Id = 11, Name = "Call", Rating = "4.6", ReleaseYear = 2020, Genre = "Thriller/Mystery", Cover = "/image/call.jpeg" , Link = "https://www.youtube.com/embed/hxkKeniT-0Q?si=xLLAXBiVT97VvakF"},
            new MovieViewModel { Id = 12, Name = "Goyo: The Boy General", Rating = "4.9", ReleaseYear = 2018, Genre = "War/History", Cover = "/image/goyo.jpeg" , Link = "https://www.youtube.com/embed/tiQnXS6wgdY?si=OD3lR4C7ZDcAesMc"},
            new MovieViewModel { Id = 13, Name = "The Hows of Us", Rating = "4.7", ReleaseYear = 2018, Genre = "Drama", Cover = "/image/thou.jpeg" , Link = "https://www.youtube.com/embed/9C5w28q6JgA?si=wRQkiXx9xnfSk96m"},
            new MovieViewModel { Id = 14, Name = "The Equalizer", Rating = "4.6", ReleaseYear = 2014, Genre = "Action/Thriller", Cover = "/image/equalizer.jpeg" , Link = "https://www.youtube.com/embed/VjctHUEmutw?si=UR927AinRPdUdmv_"},
            new MovieViewModel { Id = 15, Name = "A Man Called Otto", Rating = "4.5", ReleaseYear = 2022, Genre = "Drama/Comedy", Cover = "/image/a man called otto.jpeg" , Link = "https://www.youtube.com/embed/eFYUX9l-m5I?si=KIlNh3xkCJLA5W0K"}
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


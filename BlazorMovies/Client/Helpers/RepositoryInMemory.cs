using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Helpers
{
    public class RepositoryInMemory : IRepository
    {
        public List<Movie> GetMovies()
            {
            return new List<Movie>()
        {
                    new Movie(){Title = "Spider-Man", ReleaseDate = new DateTime(2019, 7, 2), Poster="https://musicart.xboxlive.com/7/e80f5100-0000-0000-0000-000000000002/504/image.jpg?w=1920&h=1080"},
                    new Movie(){Title = "Moana", ReleaseDate = new DateTime(2016, 11, 23), Poster="https://play-lh.googleusercontent.com/fWs8MchFvA6pjWOy9-JPPFUaKZ8ZPf-NnctYDJzCZD1widC4ccjoJaseKdi5tsU4TBW_Ziu4u1a3Ydxqycjd" },
                    new Movie(){Title = "Inception", ReleaseDate = new DateTime(2010, 7, 16), Poster="https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_UX182_CR0,0,182,268_AL_.jpg"}
        };
    }
}
    }

using System;
using System.Collections.Generic;
using Shwetha.Models;

namespace Shwetha.EF.ShwethaService
{
    public interface IShwethaService : IDisposable
    {
        /// <summary>
        /// List of movies
        /// </summary>
        /// <returns>List of movies</returns>
        List<MoviesViewModel> GetListOfMovies();

        MoviesViewModel GetMovieDetailsById(int id);

    }
}
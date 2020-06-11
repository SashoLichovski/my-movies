using my_movies.Data;
using my_movies.Service.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace my_movies.Service.Interfaces
{
    public interface IMovieService
    {
        List<Movie> GetAll();
        Movie MovieDetailsById(int id);
        List<Movie> SearchMovies(string search);
        void AddMovie(Movie movie);
        void Remove(int id);
        Movie GetById(int id);
        void Update(Movie movie);
        void AddForApproval(Movie movie);
        List<Movie> GetAllForApprove();
        void ApproveMovie(Movie movie);
        SidebarData SidebarData();
    }
}

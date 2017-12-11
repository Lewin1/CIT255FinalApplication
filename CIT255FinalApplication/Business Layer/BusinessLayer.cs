using CIT255FinalApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIT255FinalApplication
{
    class BusinessLayer
    {
        Data.RepositoryXML Repository = new Data.RepositoryXML();

        public List<Movie> DisplayAllMovies()
        {
            List<Movie> movies = new List<Movie>();

            movies = Repository.ReadAllMovies();

            return movies;
        }

        public void addMovie(Movie movie)
        {
            Repository.Add(movie);
        }

        public void deleteMovie(int ID)
        {
            Repository.Delete(ID);
        }

        public void updateMovie(Movie movie)
        {
            deleteMovie(movie.ID);
            addMovie(movie);
        }

        public void VoteUp(Movie movie)
        {
            if (movie == null)
            {
                MessageBox.Show("Please select a movies from the list above.");
            } else
            {
                movie.UpdateRating(true);
                updateMovie(movie);
            }
        }

        public void VoteDown(Movie movie)
        {
            if (movie == null)
            {
                MessageBox.Show("Please select a movies from the list above.");
            } else
            {
                movie.UpdateRating(false);
                updateMovie(movie);
            }
        }

        public List<Movie> QueryMoviesByName (string name)
        {
            List<Movie> movies = DisplayAllMovies();
            List<Movie> matchingMovies = new List<Movie>();
            
            foreach (Movie movie in movies)
            {
                if (movie.Name.ToUpper() == name)
                {
                    matchingMovies.Add(movie);
                }
            }

            return matchingMovies;
        }

        public List<Movie> QueryMoviesByGenre(string genre)
        {
            List<Movie> movies = DisplayAllMovies();
            List<Movie> matchingMovies = new List<Movie>();

            foreach (Movie movie in movies)
            {
                if (movie.Genre.ToUpper() == genre)
                {
                    matchingMovies.Add(movie);
                }
            }

            return matchingMovies;
        }

        public List<Movie> QueryMoviesByRating(int rating)
        {
            List<Movie> movies = DisplayAllMovies();
            List<Movie> matchingMovies = new List<Movie>();

            foreach (Movie movie in movies)
            {
                if (movie.UserRating == rating)
                {
                    matchingMovies.Add(movie);
                }
            }

            return matchingMovies;
        }

        public List<Movie> QueryMoviesByID(int ID)
        {
            List<Movie> movies = DisplayAllMovies();
            List<Movie> matchingMovies = new List<Movie>();

            foreach (Movie movie in movies)
            {
                if (movie.UserRating == ID)
                {
                    matchingMovies.Add(movie);
                }
            }

            return matchingMovies;
        }

        public int IncrementID(List<Movie> movies)
        {
            int ID = 0;

            if (movies.Count() != 0)
            {
                Movie lastMovie = movies[movies.Count - 1];

                ID = lastMovie.ID;
            }

            return ID += 1;
        }
        
        public void ReSortListID(List<Movie> movies)
        {
            List<Movie> sortedMovies = new List<Movie>();
            int x = 1;

            foreach (Movie movie in movies)
            {
                movie.ID = x;
                x++;
                sortedMovies.Add(movie);
            }

            Repository.AddAllMovies(sortedMovies);
        }
        
    }
}

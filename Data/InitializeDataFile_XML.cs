using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;
using CIT255FinalApplication.Model;
using System.Xml.Serialization;
using System.IO;

namespace CIT255FinalApplication
{
    public class InitializeDataFile_XML : IDisposable
    {
        private List<Movie> _movies;

        public void MovieRepository()
        {
            _movies = ReadAllMovies();
        }

        public List<Movie> ReadAllMovies()
        {
            List<Movie> movies;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Movie>), new XmlRootAttribute("Movies"));

            using (FileStream stream = File.OpenRead(@"Data.xml"))
            {
                movies = (List<Movie>)serializer.Deserialize(stream);
            }

            return movies;
        }

        public void WriteAllMovies()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Movie>), new XmlRootAttribute("Movies"));

            using (FileStream stream = File.OpenWrite("Data\\Data.xml"))
            {
                serializer.Serialize(stream, _movies);
            }
        }

        public void AddMovie(Movie movie)
        {
            _movies.Add(movie);
            WriteAllMovies();
        }

        public void DeleteMoive(int id)
        {
            int x = 0;
            while (x <= _movies.Count)
            {
                if (id == _movies.Count)
                {
                    _movies.Remove(_movies[id]);
                }
                x++;
            }

            //_movies.RemoveAll(m => m.ID == id);
            WriteAllMovies();
        }

        public void UpdateMovie(Movie movie)
        {
            DeleteMoive(movie.ID);
            AddMovie(movie);
            WriteAllMovies();
        }

        public void Dispose()
        {
            _movies = null;
        }

        public List<Movie> GetAllMovies()
        {
            return _movies;
        }
    }
}

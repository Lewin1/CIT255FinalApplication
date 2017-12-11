using CIT255FinalApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Data;

namespace CIT255FinalApplication.Data
{
    class RepositoryXML
    {
        public List<Movie> _movies = new List<Movie>();

        public RepositoryXML()
        {
            _movies = ReadAllMovies();
        }

        public void WriteAllMovies()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Movie>), new XmlRootAttribute("Movies"));

                using (FileStream stream = File.Create(DAL.Data.dataFilePath))
                {
                    serializer.Serialize(stream, _movies);
                }

        }

        public List<Movie> ReadAllMovies()
        {
            List<Movie> movies;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Movie>), new XmlRootAttribute("Movies"));

            using (FileStream stream = File.OpenRead(DAL.Data.dataFilePath))
            {
                movies = (List<Movie>)serializer.Deserialize(stream);
            }

            return movies;
        }

        public void Add(Movie movie)
        {
            _movies.Add(movie);

            WriteAllMovies();
        }

        public void Delete(int ID)
        {
            _movies.RemoveAll(m => m.ID == ID);
            WriteAllMovies();

        }

        public void AddAllMovies(List<Movie> movies)
        {
            _movies = movies;

            WriteAllMovies();
        }
    }
}

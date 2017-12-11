using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT255FinalApplication.Model
{
    public class Movie
    {
        public int ID { get; set; }
        public string Genre { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int UserRating { get; set; }

        public Movie()
        {

        }

        public void UpdateRating(bool ratingchange)
        {
            //true moves the rating up. false moves the rating down.
            if (ratingchange == true)
            {
                this.UserRating += 1;
            } else
            {
                this.UserRating -= 1;
            }
        }

        public override string ToString()
        {
            string movieDetails = "";
            int x = 1;

            movieDetails += "ID: " + ID + "     Name: ";

            while (x <= 40)
            {
                if (Name.Length == x)
                {
                    movieDetails += Name;

                    while (x <= 40)
                    {
                        movieDetails += " ";
                        x++;
                    }
                }
                x++;
            }

            movieDetails += "Genre: ";
            x = 1;

            while (x <= 15)
            {
                if (Genre.Length == x)
                {
                    movieDetails += Genre;

                    while (x <= 15)
                    {
                        movieDetails += " ";
                        x++;
                    }
                }
                x++;
            }

            movieDetails += "Year: " + Year + "     ";
            movieDetails += "User Rating: " + UserRating;

            return movieDetails;

        }
    }

}

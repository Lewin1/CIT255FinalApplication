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
            return "ID: " + ID + "     Name: " + Name + "     Genre: " + Genre + "     Year: " + Year + "     User Rating: " + UserRating;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Full_Course_Csharp
{
    class Movie
    {
        public string title;
        public string director;
        private string rating;

        // create constructor
        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "G" || value == "B" || value == "GK")
                {
                    rating = value;
                }
                else
                {
                    rating = "TruongQuocKhai";
                }
            }
        }
    }

    
}

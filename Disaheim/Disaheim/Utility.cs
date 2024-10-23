using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Disaheim;

namespace UtilityLib
{
    public class Utility
    {
        //public double GetValueOfBook(Book book)
        //{
        //    return book.Price;
        //}

        //public double GetValueOfAmulet(Amulet amulet)
        //{
        //    //Output:	Amulettens værdi returneres.
        //    // Værdien fastsættes ud fra amulettens kvalitet: 
        //    //low-> 12.5, medium-> 20.0 og high -> 27.5
        //    return amulet.Quality switch
        //    {
        //        Level.low => 12.5,
        //        Level.medium => 20.0,
        //        Level.high => 27.5,
        //    };
        //}
        private List<Merchandise> merchandises = new List<Merchandise>();

        public double GetValueOfCourse(Course course)
        {
            int hours = course.DurationInMinutes / 60;
            if(course.DurationInMinutes % 60 > 0)
            {
                hours++;
            }
            return hours * 875;
        }

        public double GetValueOfMerchandise(Merchandise merchandise)
        {
            if (merchandise is Amulet amulet)
            {
                return amulet.Quality switch
                {
                    Level.low => 12.5,
                    Level.medium => 20.0,
                    Level.high => 27.5,
                };
            }else if (merchandise is Book book)
            {
                return book.Price;
            }

            return 0;
        }
    }
}

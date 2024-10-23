using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {
        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        public double GetValueOfAmulet(Amulet amulet)
        {
            //Output:	Amulettens værdi returneres.
            // Værdien fastsættes ud fra amulettens kvalitet: 
            //low-> 12.5, medium-> 20.0 og high -> 27.5
            return amulet.Quality switch
            {
                Level.low => 12.5,
                Level.medium => 20.0,
                Level.high => 27.5,
            };
        }

        public double GetValueOfCourse(Course course)
        {
            int hours = course.DurationInMinutes / 60;
            if(course.DurationInMinutes % 60 > 0)
            {
                hours++;
            }
            return hours * 875;
        }
    }
}

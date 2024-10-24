//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.PortableExecutable;
//using System.Text;
//using System.Threading.Tasks;
//using Disaheim;

//namespace UtilityLib
//{
//    public class Utility
//    {
//        public double LowQualityValue { get; set; } = 12.5;
//        public double MediumQualityValue { get; set; } = 20.0;
//        public double HighQualityValue { get; set; } = 27.5;
//        public double CourseHourValue { get; set; } = 875;




//        //public double GetValueOfBook(Book book)
//        //{
//        //    return book.Price;
//        //}

//        //public double GetValueOfAmulet(Amulet amulet)
//        //{
//        //    //Output:	Amulettens værdi returneres.
//        //    // Værdien fastsættes ud fra amulettens kvalitet: 
//        //    //low-> 12.5, medium-> 20.0 og high -> 27.5
//        //    return amulet.Quality switch
//        //    {
//        //        Level.low => 12.5,
//        //        Level.medium => 20.0,
//        //        Level.high => 27.5,
//        //    };
//        //}
//        private List<Merchandise> merchandises = new List<Merchandise>();

            //public double GetValueOfCourse(Course course)
            //{
            //    int hours = course.DurationInMinutes / 60;
            //    if (course.DurationInMinutes % 60 > 0)
            //    {
            //        hours++;
            //    }
            //    return hours * CourseHourValue;
            //}

//        public double GetValueOfMerchandise(Merchandise merchandise)
//        {
//            if (merchandise is Amulet amulet)
//            {
//                return amulet.Quality switch
//                {
//                    Level.low => LowQualityValue,
//                    Level.medium => MediumQualityValue,
//                    Level.high => HighQualityValue,
//                };
//            }else if (merchandise is Book book)
//            {
//                return book.Price;
//            }

//            return 0;
//        }
//    }
//}

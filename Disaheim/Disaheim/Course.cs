using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course : IValuable
    {
        public string Name;
        public int DurationInMinutes;
        public static double CourseHourValue { get; set; } = 875;


        public Course(string name, int durationInMinutes)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
        }
        public Course(string name) : this(name, 0)
        {

        }

        public override string ToString()
        {
            //Name: Spådomskunst for nybegyndere, Duration in Minutes: 0, Value: 0
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}, Value: {GetValue()}";
        }

        public double GetValue()
        {
            int hours = DurationInMinutes / 60;
            if (DurationInMinutes % 60 > 0)
            {
                hours++;
            }
            return hours * CourseHourValue;
        }
    }
}

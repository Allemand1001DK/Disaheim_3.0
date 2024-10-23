using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course
    {
        public string Name;
        public int DurationInMinutes;

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
            //Name: Spådomskunst for nybegyndere, Duration in Minutes: 0
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}";
        }
    }
}

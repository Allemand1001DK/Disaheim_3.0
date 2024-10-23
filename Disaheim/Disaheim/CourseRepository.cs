using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLib;

namespace Disaheim
{
    public class CourseRepository : Merchandise
    {
        private List<Course> Course = new List<Course>();

        public void AddCourse(Course course)
        {
            Course.Add(course);
        }

        public Course GetCourse(string name)
        {
            foreach (var amulet in Course)
            {
                if (amulet.Name == name)
                {
                    return amulet;
                }
            }
            return null;
        }

        public double GetTotalValue()
        {
            Utility utility = new Utility();
            double value = 0;
            foreach (var course in Course)
            {
                value += utility.GetValueOfCourse(course);
            }
            return value;
        }
    }
}
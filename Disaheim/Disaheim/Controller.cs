using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {
        public ValuableRepository ValuebleRepo;
        public List<Book> Books = new List<Book>();
        public List<Amulet> Amulets = new List<Amulet>();
        public List<Course> Courses = new List<Course>();

        public void AddToList(Book book)
        {
            Books.Add(book);
        }
        
        public void AddToList(Amulet amulet)
        {
            Amulets.Add(amulet);
        }

        public void AddToList(Course course)
        {
            Courses.Add(course);
        }

        public void AddToList(IValuable valuable)
        {
            ValuebleRepo.AddValuable(valuable);
        }
    }
}

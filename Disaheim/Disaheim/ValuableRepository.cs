using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class ValuableRepository : IPersistable
    {
        private List<IValuable> valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }

        public IValuable? GetValuable(string id)
        {
            foreach (IValuable valuable in valuables)
            {
                if (valuable is Merchandise merchandise)
                {
                    if (merchandise.ItemId == id)
                    {
                        return merchandise;
                    }
                }
                else if (valuable is Course course)
                {
                    if (course.Name == id)
                    {
                        return course;
                    }
                }
            }
            return null;
        }

        public double GetTotalValue()
        {
            double totalValue = 0;
            foreach (IValuable valuable in valuables)
            {
                totalValue += valuable.GetValue();
            }
            return totalValue;
        }

        public int Count()
        {
            return valuables.Count;
        }

        //public void Save()
        //{
        //    StreamWriter writer = new StreamWriter("ValuableRepository.txt");
            
        //        foreach (IValuable valuable in valuables)
        //        {
        //            if (valuable is Book book)
        //            {
        //                writer.WriteLine($"BOG;{book.ItemId};{book.Title};{book.Price}");
        //            }
        //            else if (valuable is Amulet amulet)
        //            {
        //                writer.WriteLine($"AMULET;{amulet.ItemId};{amulet.Design};{amulet.Quality}");
        //            }
        //            else if (valuable is Course course)
        //            {
        //                writer.WriteLine($"COURSE;{course.Name};{course.DurationInMinutes}");
        //            }
        //        }
        //    writer.Close();
        //}

        public void Save(string fileName = "ValuableRepository.txt")
        {
            try
            {
                StreamWriter writer = new StreamWriter(fileName, false);
                
                    foreach (IValuable valuable in valuables)
                    {
                        if (valuable is Book book)
                        {
                            writer.WriteLine($"BOG;{book.ItemId};{book.Title};{book.Price}");
                        }
                        else if (valuable is Amulet amulet)
                        {
                            writer.WriteLine($"AMULET;{amulet.ItemId};{amulet.Design};{amulet.Quality}");
                        }
                        else if (valuable is Course course)
                        {
                            writer.WriteLine($"COURSE;{course.Name};{course.DurationInMinutes}");
                        }
                    }
                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        //public void Load()
        //{
        //    StreamReader reader = new StreamReader("ValuableRepository.txt");

        //    string? item;
        //    while ((item = reader.ReadLine()) != null)
        //    {
        //        Console.WriteLine($"Loading item: {item}"); // Debug print
        //        string[] itemArray = item.Split(';');

        //        switch (itemArray[0])
        //        {
        //            case "BOG":
        //                Book book = new Book(itemArray[1], itemArray[2], double.Parse(itemArray[3]));
        //                AddValuable(book);
        //                break;
        //            case "AMULET":
        //                Amulet amulet = new Amulet(itemArray[1], (Level)Enum.Parse(typeof(Level), itemArray[3]), itemArray[2]);
        //                AddValuable(amulet);
        //                break;
        //            case "COURSE":
        //                Course course = new Course(itemArray[1], int.Parse(itemArray[2]));
        //                AddValuable(course);
        //                break;
        //        }
        //    }
        //    reader.Close();

        //}

        public void Load(string filename = "ValuableRepository.txt")
        {
            StreamReader reader = new StreamReader(filename);
            
                string? item;
                while ((item = reader.ReadLine()) != null)
                {
                    Console.WriteLine($"Loading item: {item}"); // Debug print
                    string[] itemArray = item.Split(';');

                    switch (itemArray[0])
                    {
                        case "BOG":
                            Book book = new Book(itemArray[1], itemArray[2], double.Parse(itemArray[3]));
                            AddValuable(book);
                            break;
                        case "AMULET":
                            Amulet amulet = new Amulet(itemArray[1], (Level)Enum.Parse(typeof(Level), itemArray[3]), itemArray[2]);
                            AddValuable(amulet);
                            break;
                        case "COURSE":
                            Course course = new Course(itemArray[1], int.Parse(itemArray[2]));
                            AddValuable(course);
                            break;
                    }
                }
            reader.Close();
        }
    }
}

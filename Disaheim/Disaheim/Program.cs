namespace Disaheim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1, b2, b3;
            Amulet a1, a2, a3;
            Course c1, c2;
            ValuableRepository vr1, vr2;

            b1 = new Book("No. B1");
            b2 = new Book("No. B2", "Falling in Love with Yourself");
            b3 = new Book("No. B3", "Spirits in the Night", 123.55);
            a1 = new Amulet("No. A1");
            a2 = new Amulet("No. A2", Level.high);
            a3 = new Amulet("No. A3", Level.low, "Modern");
            c1 = new Course("Basis kursus");
            c2 = new Course("Kursus 2", 128);

            vr1 = new ValuableRepository();
            vr1.AddValuable(b1);
            vr1.AddValuable(a1);
            vr1.AddValuable(b2);
            vr1.AddValuable(a3);
            vr1.AddValuable(c1);
            vr1.AddValuable(b3);
            vr1.AddValuable(a2);
            vr1.AddValuable(c2);

            // Save the valuables to a file
            vr1.Save("ValuableRepository.txt");

            vr2 = new ValuableRepository();

            // Load the valuables from the file
            vr2.Load("ValuableRepository.txt");

            // Check the count of loaded valuables
            Console.WriteLine($"Loaded valuables count: {vr2.Count()}");

            if (File.Exists("ValuableRepository.txt"))
            {
                File.Delete("ValuableRepository.txt");
            }
            if (File.Exists("TestFile01.txt"))
            {
                File.Delete("TestFile01.txt");
            }
            if (File.Exists("TestFile02.txt"))
            {
                File.Delete("TestFile02.txt");
            }

            vr1.Save();
            vr2.Load();
            int noOfElements = vr1.Count();
        }
    }
}

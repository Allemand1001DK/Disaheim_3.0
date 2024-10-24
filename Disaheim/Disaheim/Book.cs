using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book : Merchandise
    {
        //
        public string Title { get; set; }
        public double Price { get; set; }

        public Book(string itemId, string title, double price) 
        {
            ItemId = itemId;
            Title = title;
            Price = price;
        }

        public Book(string itemId, string title) : this(itemId, title, 0)
        {

        }

        public Book(string itemId) : this(itemId, null, 0)
        {

        }

        public override string ToString()
        {
            //ItemId: 2, Title: Falling in Love with Yourself, Price: 0
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }
    }
}

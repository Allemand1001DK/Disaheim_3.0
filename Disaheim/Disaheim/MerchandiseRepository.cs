using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLib;

namespace Disaheim
{
    public class MerchandiseRepository : Merchandise
    {
        private List<Merchandise> merchandises = new List<Merchandise>();

        public void AddMerchandise(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
        }

        public Merchandise GetMerchandise(string itemId)
        {
            foreach (var merchandise in merchandises)
            {
                if (merchandise.ItemId == itemId)
                {
                    
                    return merchandise;
                }
            }
            return null;
        }

        public double GetTotalValue()
        {
            Utility utility = new Utility();
            double value = 0;
            foreach (Merchandise merchandise in merchandises)
            {
                value = +utility.GetValueOfMerchandise(merchandise);
            }
            return value;
        }
    }
}

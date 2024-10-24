using System;
using System.Collections.Generic;
using UtilityLib;

namespace Disaheim
{
    public class MerchandiseRepository
    {
        private List<Merchandise> merchandises = new List<Merchandise>();

        public void AddMerchandise(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
        }


        //Skal tjekke om det er en amulet eller book og returnere det. 
        //Forventer ItemId: 13, Quality: low, Design: Capricorn men får null
        public Merchandise? GetMerchandise(string itemId)
        {
            foreach (Merchandise merchandise in merchandises)
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
                value += utility.GetValueOfMerchandise(merchandise);
            }
            return value;
        }
    }
}
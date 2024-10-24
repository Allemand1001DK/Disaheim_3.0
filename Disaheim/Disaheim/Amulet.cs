using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet : Merchandise
    {
        public string Design { get; set; }
        public Level Quality { get; set; }
        public static double LowQualityValue { get; set; } = 12.5;
        public static double MediumQualityValue { get; set; } = 20.0;
        public static double HighQualityValue { get; set; } = 27.5;

        public Amulet(string itemId, Level quality, string design) 
        {
            ItemId = itemId;
            Quality = quality;
            Design = design;
        }

        public Amulet(string itemId, Level quality) : this(itemId, quality, null)
        {

        }

        public Amulet(string itemId) : this(itemId, Level.medium, null)
        {

        }

        public override double GetValue()
        {
            double value = 0;
            switch (Quality)
            {
                case Level.low:
                    value = LowQualityValue;
                    break;
                case Level.medium:
                    value = MediumQualityValue;
                    break;
                case Level.high:
                    value = HighQualityValue;
                    break;
            }
            return value;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
    }
}

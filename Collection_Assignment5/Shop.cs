using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Assignment5
{
    public class Shop : Estate
    {
        public Shop(double area, decimal pricePerSquareMeter, string location)
            : base(area, pricePerSquareMeter, location)
        {
        }

        public override string ToString()
        {
            return $"Shop - {base.ToString()}";
        }
    }

}

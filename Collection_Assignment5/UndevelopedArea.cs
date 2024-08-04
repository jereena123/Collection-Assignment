using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Assignment5
{
    public class UndevelopedArea : Estate
    {
        public UndevelopedArea(double area, decimal pricePerSquareMeter, string location)
            : base(area, pricePerSquareMeter, location)
        {
        }

        public override string ToString()
        {
            return $"Undeveloped Area - {base.ToString()}";
        }
    }
}

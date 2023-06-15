using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class ByBicycleDeliveryStrategy : IDeliveryStrategy
    {
        public double CalculateShippingCost(double price)
        {
            return price + 20;
        }
    }
}

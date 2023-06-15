using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class DeliveryContext
    {
        private IDeliveryStrategy _strategy;
        public DeliveryContext(IDeliveryStrategy strategy)
        {
            _strategy = strategy;
        }
        public double CalculateShippingCost(double price)
        {
            return _strategy.CalculateShippingCost(price);
        }
    }
}

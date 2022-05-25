using Delivery.Rations;

namespace Delivery
{
    public class Order
    {
        public Rations.RationType Type { get; set; }
        public int CountDay { get; set; }
    }
}
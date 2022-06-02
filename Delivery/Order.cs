using Delivery.Rations;

namespace Delivery
{
    /// <summary>
    /// Заказ
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Тип рациона в заказе
        /// </summary>
        public Rations.RationType Type { get; set; }
        /// <summary>
        /// Количество дней доставки
        /// </summary>
        public int CountDay { get; set; }
    }
}
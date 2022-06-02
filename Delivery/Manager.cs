using Delivery.Collectors;
using Delivery.Rations;
using Spectre.Console;

namespace Delivery
{
    /// <summary>
    /// Менеджер
    /// </summary>
    public class Manager
    {
        private CollectorBuilder? _collector; // Паттерн билдера, тут менеджер в виде директора
        /// <summary>
        /// Заказ
        /// </summary>
        private Order? Order { get; set; }
        /// <summary>
        /// Список зарегестрированный чеков
        /// </summary>
        public List<Check>? CheckList { get; private set; }
        /// <summary>
        /// Собрать заказ
        /// </summary>
        /// <param name="order">Заказ</param>
        /// В метод закидываем заказ, по типу заказа он определяет, какого именно сборщика задейстовать для сборки заказа
        public void CollectOrder(Order order)
        {
            AnsiConsole.Status().Start("[green]Сбор заказа...[/]", ctx =>
                {
                    Thread.Sleep(300);

                    AnsiConsole.MarkupLine("Ожидайте, Ваш заказ на сборке...");
                    Thread.Sleep(300);

                    ctx.SpinnerStyle(Style.Parse("red"));

                    AnsiConsole.MarkupLine("Практически все собрано..");
                    Thread.Sleep(300);
                });
            Order = order;
            switch (order.Type)
            {
                case RationType.Balance:
                    _collector = new BalanceCollector();
                    _collector.CollectRation();
                    RegisterCheck();
                    break;
                case RationType.Default:
                    _collector = new DefaultCollector();
                    _collector.CollectRation();
                    RegisterCheck();
                    break;
                case RationType.Sport:
                    _collector = new SportCollector();
                    _collector.CollectRation();
                    RegisterCheck();
                    break;
                case RationType.Vegan:
                    _collector = new VeganCollector();
                    _collector.CollectRation();
                    RegisterCheck();
                    break;
                case RationType.Premium:
                    _collector = new PremiumCollector();
                    _collector.CollectRation();
                    RegisterCheck();
                    break;
            }
            AnsiConsole.Write(new Markup("[green]Заказ[/] [green]собран[/]\n"));
        }
        /// <summary>
        /// Выдать рацион
        /// </summary>
        /// <returns>Возращает рацион</returns>
        public IRation GetRation()
        {
            return _collector?.GetRation()!;
        }
        /// <summary>
        /// Зарегестрировать чек
        /// </summary>
        private void RegisterCheck()
        {
            Check buffer = new Check(GetRation(), Order!);
            if (CheckList == null!)
            {
                CheckList = new List<Check>();
                CheckList!.Add(buffer);
            }
            else
            {
                CheckList!.Add(buffer);
            }
        }

    }
}

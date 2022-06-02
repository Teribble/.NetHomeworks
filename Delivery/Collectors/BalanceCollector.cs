namespace Delivery.Collectors
{
    /// <summary>
    /// Сборщик сбалансированного рациона
    /// </summary>
    public class BalanceCollector : CollectorBuilder
    {
        protected override string Path { get; set; }
        public BalanceCollector()
        {
            Path = "Rations/JSON/Balance.json";
        }
    }
}

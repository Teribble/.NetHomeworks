namespace Delivery.Collectors
{
    public class BalanceCollector : CollectorBuilder
    {
        protected override string Path { get; set; }
        public BalanceCollector()
        {
            Path = "Rations/JSON/Balance.json";
        }
    }
}

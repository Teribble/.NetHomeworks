namespace Delivery.Collectors
{
    public class PremiumCollector : CollectorBuilder
    {
        protected override string Path { get; set; }
        public PremiumCollector()
        {
            Path = "Rations/JSON/Premium.json";
        }
    }
}

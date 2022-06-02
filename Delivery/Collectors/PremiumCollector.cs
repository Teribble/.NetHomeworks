namespace Delivery.Collectors
{
    /// <summary>
    /// Сборщик премиум рациона
    /// </summary>
    public class PremiumCollector : CollectorBuilder
    {
        protected override string Path { get; set; }
        public PremiumCollector()
        {
            Path = "Rations/JSON/Premium.json";
        }
    }
}

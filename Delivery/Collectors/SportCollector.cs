namespace Delivery.Collectors
{
    /// <summary>
    /// Сборщик спортивного рациона
    /// </summary>
    public class SportCollector : CollectorBuilder
    {
        protected override string Path { get; set; }
        public SportCollector()
        {
            Path = "Rations/JSON/Sport.json";
        }
    }
}

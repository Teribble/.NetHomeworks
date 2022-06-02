namespace Delivery.Collectors
{
    /// <summary>
    /// Сборщик вегетарианского рациона
    /// </summary>
    public class VeganCollector : CollectorBuilder
    {
        protected override string Path { get; set; }
        public VeganCollector()
        {
            Path = "Rations/JSON/Vegan.json";
        }
    }
}

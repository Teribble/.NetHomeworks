namespace Delivery.Collectors
{
    public class DefaultCollector : CollectorBuilder
    {
        protected override string Path { get; set; }
        public DefaultCollector()
        {
            Path = "Rations/JSON/Default.json";
        }
    }
}

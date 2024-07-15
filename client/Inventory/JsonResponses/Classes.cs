using System.Text.Json.Serialization;

namespace Inventory.JsonResponses
{   
    public class StockType
    {
        [JsonPropertyName("c")]
        public string? Category { get; set; }

        [JsonPropertyName("s")]
        public int Stock { get; set; }
    }

    public class DailyOrder
    {
        [JsonPropertyName("date")]
        public int Date { get; set; }

        [JsonPropertyName("orders")]
        public int Orders { get; set; }
    }

    public class BestSeller
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
    }
}
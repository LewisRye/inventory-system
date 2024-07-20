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
        public DateTime Date { get; set; }

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
    
    public class AccessLevel
    {
        [JsonPropertyName("level_id")]
        public int Id { get; set; }

        [JsonPropertyName("level_name")]
        public string? Name { get; set; }
    }

    public class Order
    {
        [JsonPropertyName("order_id")]
        public int Id { get; set; }

        [JsonPropertyName("product_name")]
        public string? Name { get; set; }

        [JsonPropertyName("fname")]
        public string? Fname { get; set; }

        [JsonPropertyName("lname")]
        public string? Lname { get; set; }

        [JsonPropertyName("quantity_ordered")]
        public int Quantity { get; set; }

        [JsonPropertyName("order_date")]
        public DateTime Date { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }
    }

    public class Product
    {
        [JsonPropertyName("product_id")]
        public int Id { get; set; }

        [JsonPropertyName("product_name")]
        public string? ProdName { get; set; }

        [JsonPropertyName("category_id")]
        public int CatId { get; set; }

        [JsonPropertyName("number_in_stock")]
        public int Stock { get; set; }

        [JsonPropertyName("buy_price")]
        public decimal Price { get; set; }

        [JsonPropertyName("discontinued")]
        public int Discontinued { get; set; }
    }

    public class Category
    {
        [JsonPropertyName("category_id")]
        public int Id { get; set; }

        [JsonPropertyName("category_name")]
        public string? Name { get; set; }
    }
}
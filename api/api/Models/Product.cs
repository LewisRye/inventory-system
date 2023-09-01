using System;
using System.Collections.Generic;

namespace api.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public int? CategoryId { get; set; }

    public int? NumberInStock { get; set; }

    public decimal? BuyPrice { get; set; }

    public string? Discontinued { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<CustomerOrderDetail> CustomerOrderDetails { get; set; } = new List<CustomerOrderDetail>();
}

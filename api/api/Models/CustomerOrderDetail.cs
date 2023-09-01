using System;
using System.Collections.Generic;

namespace api.Models;

public partial class CustomerOrderDetail
{
    public int OrderId { get; set; }

    public int? ProductId { get; set; }

    public int? QuantityOrdered { get; set; }

    public virtual CustomerOrder Order { get; set; } = null!;

    public virtual Product? Product { get; set; }
}

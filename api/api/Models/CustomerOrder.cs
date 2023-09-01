using System;
using System.Collections.Generic;

namespace api.Models;

public partial class CustomerOrder
{
    public int OrderId { get; set; }

    public int? CustomerId { get; set; }

    public DateOnly? OrderDate { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual CustomerOrderDetail? CustomerOrderDetail { get; set; }
}

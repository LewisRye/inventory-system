using System;
using System.Collections.Generic;

namespace api.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? CustomerFname { get; set; }

    public string? CustomerLname { get; set; }

    public string? CustomerAddress { get; set; }

    public long? CustomerPhone { get; set; }

    public virtual ICollection<CustomerOrder> CustomerOrders { get; set; } = new List<CustomerOrder>();
}

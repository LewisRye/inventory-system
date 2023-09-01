using System;
using System.Collections.Generic;

namespace api.Models;

public partial class Account
{
    public int AccountId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public int? LevelId { get; set; }

    public string? Username { get; set; }

    public string? Passhash { get; set; }

    public virtual AccessLevel? Level { get; set; }

    public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();
}

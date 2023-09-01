using System;
using System.Collections.Generic;

namespace api.Models;

public partial class AccessLevel
{
    public int LevelId { get; set; }

    public string? LevelName { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}

using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class FlashCard
{
    public int Id { get; set; }

    public string? Question { get; set; }

    public string? Answer { get; set; }
}

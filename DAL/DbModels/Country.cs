using System;
using System.Collections.Generic;

namespace DAL.DbModels;

public partial class Country
{
    public int CountryId { get; set; }

    public string CountryName { get; set; } = null!;

    public int? FromYear { get; set; }

    public int? ToYear { get; set; }

    public string? StateBorders { get; set; }
}

using System;
using System.Collections.Generic;

namespace DAL.DbModels;

public partial class HistoryEvent
{
    public int EventId { get; set; }

    public string TiteleEvent { get; set; } = null!;

    public int? CountryId { get; set; }

    public string? Edescription { get; set; }

    public string? Ecity { get; set; }

    public int? Eyear { get; set; }

    public DateTime? EventDate { get; set; }
}



using System;
using System.Collections.Generic;

namespace DAL.DbModels;

public partial class Person
{
    public int PeopleId { get; set; }

    public string PeopleName { get; set; } = null!;

    public string? PeopleRole { get; set; }

    public DateTime? BirthDate { get; set; }

    public DateTime? DeathDate { get; set; }

    public int? CityId { get; set; }
}

using System;
using System.Collections.Generic;

namespace MyVillageKartAPI.EntityModels;

public partial class UserDetail
{
    public string UserId { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Mobile { get; set; }

    public string? Mobile2 { get; set; }

    public string Password { get; set; } = null!;
}

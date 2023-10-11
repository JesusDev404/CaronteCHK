using System;
using System.Collections.Generic;

namespace CaronteCHK.Models.ModelDB;

public partial class User
{
    public int IdUser { get; set; }

    public string NombreCompleto { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public string Rol { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace Backend.Entities;

public partial class Finca
{
    public int FincaId { get; set; }

    public string Numero { get; set; } = null!;

    public int? Distrito { get; set; }

    public string? Direccion { get; set; }

    public virtual ICollection<Propietario> Propietarios { get; set; } = new List<Propietario>();
}

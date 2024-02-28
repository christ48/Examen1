using System;
using System.Collections.Generic;

namespace Backend.Entities;

public partial class Distrito
{
    public int DistritoId { get; set; }

    public string Nombre { get; set; } = null!;
}

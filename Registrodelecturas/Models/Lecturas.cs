using System;
using System.Collections.Generic;

namespace Registrodelecturas.Models;

public partial class Lecturas
{
    public int Id { get; set; }

    public string NombreEsp { get; set; } = null!;

    public string Variable { get; set; } = null!;

    public float Lectura { get; set; }

    public DateTime? Hora { get; set; }
}

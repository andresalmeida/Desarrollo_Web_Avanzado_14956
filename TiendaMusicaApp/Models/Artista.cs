using System;
using System.Collections.Generic;

namespace TiendaMusicaApp.Models;

public partial class Artista
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public DateOnly? Nacimiento { get; set; }

    public string? Codigo { get; set; }
}

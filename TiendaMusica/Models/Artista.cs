using System;
using System.Collections.Generic;

namespace TiendaMusica.Models;

public partial class Artista
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public DateOnly? Nacimiento { get; set; }

    public int? PlaylistId { get; set; }

    public virtual Playlist? Playlist { get; set; }
}

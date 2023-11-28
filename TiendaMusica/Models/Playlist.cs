using System;
using System.Collections.Generic;

namespace TiendaMusica.Models;

public partial class Playlist
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? Codigo { get; set; }

    public virtual ICollection<Artista> Artista { get; set; } = new List<Artista>();
}

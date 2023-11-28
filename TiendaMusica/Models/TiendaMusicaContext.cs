using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TiendaMusica.Models;

public partial class TiendaMusicaContext : DbContext
{
    public TiendaMusicaContext()
    {
    }

    public TiendaMusicaContext(DbContextOptions<TiendaMusicaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Artista> Artistas { get; set; }

    public virtual DbSet<Playlist> Playlists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
            //=> optionsBuilder.UseSqlServer("server=DESKTOP-9QK0T32\\SQLEXPRESS; database=TiendaMusica; Trusted_Connection=True; TrustServerCertificate=True;");
        }

    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Artista>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Artistas__3214EC07D73BECF2");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Playlist).WithMany(p => p.Artista)
                .HasForeignKey(d => d.PlaylistId)
                .HasConstraintName("FK_Artistas_Playlists");
        });

        modelBuilder.Entity<Playlist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Playlist__3214EC07871FBCFD");

            entity.Property(e => e.Codigo)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

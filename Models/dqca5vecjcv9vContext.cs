using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SuperCarrosASH.Models
{
    public partial class dqca5vecjcv9vContext : DbContext
    {
        public dqca5vecjcv9vContext()
        {
        }

        public dqca5vecjcv9vContext(DbContextOptions<dqca5vecjcv9vContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Carro> Carros { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("host=ec2-54-161-255-125.compute-1.amazonaws.com;port=5432;database=dqca5vecjcv9v;username=mrlduoblirfgfd;password=3f05569c1cc7076ead3a9b405ac7d646b94b34b44d1a338a2ed717c050401e56");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carro>(entity =>
            {
                entity.ToTable("carros");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Año).HasColumnName("año");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.Marca).HasColumnName("marca");

                entity.Property(e => e.Modelo).HasColumnName("modelo");

                entity.Property(e => e.Precio).HasColumnName("precio");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(255)
                    .HasColumnName("tipo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata;

namespace _0311library.modelek
{
    public partial class konyvtardbContext : DbContext
    {
        public konyvtardbContext()
        {
        }

        public konyvtardbContext(DbContextOptions<konyvtardbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Books> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;database=konyvtar;user=root;password=");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Books>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PRIMARY");

                entity.ToTable("books");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Author)
                    .HasColumnName("author")
                    .HasMaxLength(150)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("int(11)");
            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

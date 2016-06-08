using Livraria.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Entity
{
    public class Context : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var mapLivro = modelBuilder.Entity<Livro>();
            mapLivro.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            mapLivro.Property(x => x.Nome).IsVariableLength().IsRequired().HasMaxLength(150);
            mapLivro.Property(x => x.Autor).IsVariableLength().IsRequired().HasMaxLength(50);
            mapLivro.Property(x => x.Categoria).IsVariableLength().IsRequired().HasMaxLength(50);
            mapLivro.ToTable("Livros");
        }

        public System.Data.Entity.DbSet<Livraria.Modelo.Livro> Livroes { get; set; }
    }
}

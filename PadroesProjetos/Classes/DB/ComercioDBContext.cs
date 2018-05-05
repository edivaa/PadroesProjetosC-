using System;
using System.Data.Entity;
using PadroesProjetos.Classes.Objetos;
using PadroesProjetos.Classes.Outros;

namespace PadroesProjetos.Classes.DB
{
    public class ComercioDBContext : DbContext
    {
        public ComercioDBContext() : base("Name=ComercioBD")
        {
            Database.SetInitializer<ComercioDBContext>(
                new CreateDatabaseIfNotExists<ComercioDBContext>());
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Loja> Lojas { get; set; }
    }
}

using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Data.Context
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions options):base(options)
        {

            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Fornecedor> Fornecedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*Evitar que a propriedade seja criada com varchar 1000*/

            /*foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                .Where(p => p.ClrType == typeof(string))))
                 property.Relational().ColumnType = "varchar(100"; */

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuDbContext).Assembly);
            /*Impedir que uma deleção de fornecedor apague os produtos cadastrados */
            foreach(var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }


    }
}

using Microsoft.EntityFrameworkCore;
using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Context
{
    public class EFContext
    {
        public EFContext(DbContextOptions<EFContext> options): base(options) { 
            
        }
        private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=EFCore;Trusted_Connection=True;";
        // aqui seta o tipo de banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);

        }

        public override void OnModelCreating(ModelBuilder modelBuilder) { 
            base.OnModelCreating(modelBuilder)
        }
        // adiciona tabela ao banco de dados, a partir do modelo criado
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<PersonEntity> Persons { get; set; }
    }
}

using Common;
using Microsoft.EntityFrameworkCore;
using Repository.Entity;

namespace API.Context
{
    public class EFContext : DbContext
    {
        private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=EFCore;Trusted_Connection=True;";
        // aqui seta o tipo de banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);

        }
        // adiciona tabela ao banco de dados, a partir do modelo criado
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<PersonEntity> Persons { get; set; }

    }
}
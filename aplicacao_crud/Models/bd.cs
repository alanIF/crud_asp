using Microsoft.EntityFrameworkCore;

namespace aplicacao_crud.Models
{
    public class bd: DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=Crud;Integrated Security=True");
        }
    }
}

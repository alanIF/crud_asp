using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace aplicacao_crud.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=Crud;Integrated Security=True");
        }
    }
}

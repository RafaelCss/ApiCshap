using Filmes.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Data
{
    public class FilmeContext : DbContext
    {
         public FilmeContext(DbContextOptions<FilmeContext> opt) : base(opt)
        {
            
        }

        public DbSet<Filmess> Filmes {get; set;}
    }
}
using CodeFirst_Practice.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst_Practice.Context
{
    public class PatikaFirstDbContext : DbContext
    {

        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options) : base(options) 
        { 
        
        
        }
        
            
      



        public DbSet<Movie> Movies  { get; set; }

        public DbSet<Game> Games { get; set; }




    }
}

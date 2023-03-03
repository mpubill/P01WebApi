using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace P01WebApi.Models
{
    public class equiposContext : DbContext
    {

        public equiposContext(DbContextOptions<equiposContext> option) : base(option) { 
        
        }      

        public DbSet<equipos> equipos { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using vvvas.Models;

namespace vvvas
{
    public class AZContext : DbContext
    {
        public AZContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Note> Notes { get; set; }
    }
}
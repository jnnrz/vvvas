using Microsoft.EntityFrameworkCore;

namespace vvvas
{
    public class AZContext : DbContext
    {
        public AZContext(DbContextOptions options) : base(options)
        {
        }
        
        
    }
}
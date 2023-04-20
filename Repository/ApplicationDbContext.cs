using Microsoft.EntityFrameworkCore;
using Repository.DTO;

namespace Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {

        }

        public DbSet<CategoryDto> Categories { get; set; }
    }
}

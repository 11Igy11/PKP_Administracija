using Microsoft.EntityFrameworkCore;

namespace PKP_Administracija.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}

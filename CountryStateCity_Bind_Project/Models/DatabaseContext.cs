using Microsoft.EntityFrameworkCore;

namespace CountryStateCity_Bind_Project.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<TblCountry> tblCountries { get; set; }
        public DbSet<TblState> tblStates { get; set; }
        public DbSet<TblCity> tblCitys { get; set; }
    }
}

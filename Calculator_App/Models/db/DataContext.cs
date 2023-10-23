using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore;

namespace Calculator_App.Models.db
{
    public class DataContext : DbContext
    {
        public DbSet<Calculation> Calculation { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}

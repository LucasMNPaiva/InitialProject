using EventProject.Models;
using Microsoft.EntityFrameworkCore;

namespace EventProject.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Event> Events { get; set; }
    }
}
using BulkUpload.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkUpload.Data
{
    public class BulkDbContext:DbContext
    {
        public BulkDbContext(DbContextOptions<BulkDbContext> options): base(options)
        { }
        public DbSet<Employee> Employees { get; set; }
    }
}

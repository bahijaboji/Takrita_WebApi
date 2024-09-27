using Microsoft.EntityFrameworkCore;
using Takrita_WebApi.Entities;

namespace Takrita_WebApi.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product>  Products { get; set; }
    }
}

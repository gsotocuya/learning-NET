using DemoTallerCodigoFacilito.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoTallerCodigoFacilito.Data;

public class StoreDbContext : DbContext
{
    public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
    {
    }
    public DbSet<ProductEntity> Products { get; set; }

}
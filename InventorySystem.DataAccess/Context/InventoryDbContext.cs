using InventorySystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InventorySystem.DataAccess.Context;

public class InventoryDbContext : DbContext
{
    public InventoryDbContext(DbContextOptions<InventoryDbContext> options) : base(options)
    {
    }

    // Aquí registramos la tabla de Almacenes
    public DbSet<Warehouse> Warehouses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Aquí puedes agregar configuraciones extra después
    }
}
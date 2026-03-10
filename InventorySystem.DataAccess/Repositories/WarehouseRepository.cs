using InventorySystem.DataAccess.Context;
using InventorySystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InventorySystem.DataAccess.Repositories;

public class WarehouseRepository
{
    private readonly InventoryDbContext _context;

    public WarehouseRepository(InventoryDbContext context)
    {
        _context = context;
    }

    public async Task<List<Warehouse>> GetAll()
    {
        return await _context.Warehouses.ToListAsync();
    }
}
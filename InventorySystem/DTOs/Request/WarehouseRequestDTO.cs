namespace InventorySystem.API.DTOs.Request;

public class WarehouseRequestDTO
{
    // El ID no se pide aquí porque la base de datos lo genera solo (Identity)
    public string Name { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;

}

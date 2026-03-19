namespace InventorySystem.API.DTOs.Response;

public class WarehouseResponseDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;

    // Campos de auditoría que el profesor recomienda mostrar
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
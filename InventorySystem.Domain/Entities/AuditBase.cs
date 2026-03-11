namespace InventorySystem.Domain.Entities;

public abstract class AuditBase
{
    public int Id { get; set; } // Llave primaria [cite: 122, 1176]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Fecha de creación [cite: 123, 1177]
    public DateTime? UpdatedAt { get; set; } // Fecha de actualización (opcional) [cite: 124, 1178]
}
// Cambio para forzar carpetas

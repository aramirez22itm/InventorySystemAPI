
namespace InventorySystem.Domain.Entities;

[cite_start]
public class Warehouse : AuditBase // Hereda Id y fechas de AuditBase 
{
    public string Name { get; set; } = string.Empty; // Nombre del almacén [cite: 134, 1188]
    public string Address { get; set; } = string.Empty; // Dirección
    public int Capacity { get; set; } // Capacidad de almacenamiento
}


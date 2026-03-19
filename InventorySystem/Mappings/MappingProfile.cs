using AutoMapper;
using InventorySystem.API.DTOs.Request;
using InventorySystem.API.DTOs.Response;
using InventorySystem.Domain.Entities;

namespace InventorySystem.API.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // De DTO de entrada a Entidad (para crear/actualizar)
        CreateMap<WarehouseRequestDTO, Warehouse>();

        // De Entidad a DTO de salida (para mostrar al usuario)
        CreateMap<Warehouse, WarehouseResponseDTO>();
    }
}
using Microsoft.AspNetCore.Mvc;
using InventorySystem.DataAccess.Repositories;

namespace InventorySystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WarehousesController : ControllerBase
{
    // Aquí luego inyectaremos el repositorio para mostrar los almacenes
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { message = "Conexión exitosa al controlador de Almacenes" });
    }
}

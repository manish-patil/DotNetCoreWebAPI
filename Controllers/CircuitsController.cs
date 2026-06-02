using F1API.Models;
using F1API.Services;
using Microsoft.AspNetCore.Mvc;

namespace F1API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CircuitsController(ICircuitsService service) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Circuit>>> GetCircuits()
        {
            return await service.GetAllCircuitsAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Circuit?>> AddCircuit(Circuit circuit)
        { 
            var newCircuit = await service.AddCircuitAsync(circuit);

            if (newCircuit is null)
            {
                return BadRequest();
            }

            return newCircuit;
        }
    }
}

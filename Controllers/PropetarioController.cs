using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using test.Repository;
using test.Services;

namespace test.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PropetarioController : ControllerBase
    {
        private readonly IPropetarioService service;

        public PropetarioController(IPropetarioService service)
        {
            this.service = service;
        }
        [HttpGet]
        public async Task<ActionResult<List<Propetario>>> GetAllPropetarios()
        {
            var result = await service.GetAll();
            return Ok(result);
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult> GetPropetarioById(int Id)
        {
            var result = await service.GetPropetarioById(Id);
            return Ok(result);
        }
    }
}

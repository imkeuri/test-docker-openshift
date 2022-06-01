using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using test.Repository;
using test.Services;

namespace test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropetarioController : ControllerBase
    {
        private readonly IPropetarioService service;

        public PropetarioController(IPropetarioService service)
        {
            this.service = service;
        }
        [HttpGet]
        public List<Propetario> GetAllPropetarios()
        {
           return service.GetAll();
        }
    }
}

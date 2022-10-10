using ConvertAPP.Models;
using ConvertAPP.Services;
using ConvertAPP.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ConvertAPP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoClienteController : ControllerBase
    {
        
        private readonly ILogger<TipoClienteController> _logger;

        private TipoClienteInterface _tipoClienteInterface;

        public TipoClienteController(ILogger<TipoClienteController> logger, TipoClienteInterface tipoClienteInterface)
        {
            _logger = logger;

            _tipoClienteInterface = tipoClienteInterface;
        }


        [HttpGet]
        public IActionResult FindAll()
        {

            return Ok(_tipoClienteInterface.findAll());

        }
    }
}

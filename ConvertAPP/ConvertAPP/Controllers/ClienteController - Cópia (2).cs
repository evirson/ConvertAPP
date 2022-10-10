using ConvertAPP.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ConvertAPP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private ClienteInterface _clienteInterface;
        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger, ClienteInterface clienteInterface)
        {
            _logger = logger;
            _clienteInterface = clienteInterface;
        }


        [HttpGet]
        public IActionResult FindAll()
        {

            return Ok(_clienteInterface.findAll());

        }
    }
}
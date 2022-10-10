using ConvertAPP.Models.Context;
using ConvertAPP.Models;
using ConvertAPP.Services.Interfaces;

namespace ConvertAPP.Services
{
    public class TipoClienteService: TipoClienteInterface
    {
        private FbContext _context;

        public TipoClienteService(FbContext context)
        {
            _context = context;
        }

        public List<TipoCliente> findAll()
        {
            return _context.TipoClientes.ToList();
        }
    }
}

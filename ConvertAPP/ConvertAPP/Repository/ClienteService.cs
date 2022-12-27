using ConvertAPP.Models;
using ConvertAPP.Models.Context;
using ConvertAPP.Services.Interfaces;

namespace ConvertAPP.Services
{
    public class ClienteService : ClienteInterface
    {
        private FbContext _context;

        public ClienteService(FbContext context)
        {
            _context = context;
        }

        public List<Cliente> findAll()
        {
            return _context.Clientes.ToList();
        }
    }
}

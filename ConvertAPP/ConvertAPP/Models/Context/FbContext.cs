using Microsoft.EntityFrameworkCore;

namespace ConvertAPP.Models.Context
{
    public class FbContext : DbContext
    {
        public FbContext()
        {

        }

        public FbContext(DbContextOptions<FbContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<TipoCliente> TipoClientes { get; set; }  
    }
}

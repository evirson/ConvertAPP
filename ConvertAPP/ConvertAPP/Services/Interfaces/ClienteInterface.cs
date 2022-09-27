using ConvertAPP.Models;

namespace ConvertAPP.Services.Interfaces
{
    public interface ClienteInterface
    {
        List<ClienteService> findAll();
        ClienteService findById(int codCli);
        ClienteService findByName(string nomCli);
        ClienteService findByEmail(string eMail);


    }
}

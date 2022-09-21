using ConvertAPP.Models;

namespace ConvertAPP.Services.Interfaces
{
    public interface ClienteInterface
    {
        List<Cliente> findAll();
        Cliente findById(int codCli);
        Cliente findByName(string nomCli);
        Cliente findByEmail(string eMail);


    }
}

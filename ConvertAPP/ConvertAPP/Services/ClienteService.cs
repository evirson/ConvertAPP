using ConvertAPP.Services.Interfaces;

namespace ConvertAPP.Services
{
    public class ClienteService : ClienteInterface
    {
        List<ClienteService> ClienteInterface.findAll()
        {
            throw new NotImplementedException();
        }

        ClienteService ClienteInterface.findByEmail(string eMail)
        {
            throw new NotImplementedException();
        }

        ClienteService ClienteInterface.findById(int codCli)
        {
            throw new NotImplementedException();
        }

        ClienteService ClienteInterface.findByName(string nomCli)
        {
            throw new NotImplementedException();
        }
    }
}

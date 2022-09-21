using ConvertAPP.Services.Interfaces;

namespace ConvertAPP.Services
{
    public class Cliente : ClienteInterface
    {
        List<Cliente> ClienteInterface.findAll()
        {
            throw new NotImplementedException();
        }

        Cliente ClienteInterface.findByEmail(string eMail)
        {
            throw new NotImplementedException();
        }

        Cliente ClienteInterface.findById(int codCli)
        {
            throw new NotImplementedException();
        }

        Cliente ClienteInterface.findByName(string nomCli)
        {
            throw new NotImplementedException();
        }
    }
}

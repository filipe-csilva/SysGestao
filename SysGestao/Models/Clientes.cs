using Dapper.Contrib.Extensions;

namespace SysGestao.Models
{

    [Table("[Client]")]

    public class Client : Pessoa
    {
        public Client(int id, string name, string cpf, string fone, string obs) : base(id, name, cpf, fone, obs)
        {
        }
    }
}

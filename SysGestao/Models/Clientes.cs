using Dapper.Contrib.Extensions;

namespace SysGestao.Models
{

    [Table("[Client]")]

    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Fone { get; set; }
        public string Obs { get; set; }

        //public Client(int id, string name, string cpf, string fone, string obs)
        //{
        //    Id = id;
        //    Name = name;
        //    CPF = cpf;
        //    Fone = fone;
        //    Obs = obs;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao.Models
{
    public class Pessoa
    {
        public Pessoa(int id, string name, string cpf, string fone, string obs)
        {
            Id = id;
            Name = name;
            CPF = cpf;
            Fone = fone;
            Obs = obs;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Fone { get; set; }
        public string Obs { get; set; }
    }
}

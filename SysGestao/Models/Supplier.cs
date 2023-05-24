using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao.Models
{
    [Table("[Supplier]")]
    public class Supplier
    {
        public Supplier(int id, string name, string cNPJ, string end, string bairro, string cidade, string estado, string cep, string fone, string obs)
        {
            Id = id;
            Name = name;
            CNPJ = cNPJ;
            End = end;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
            Fone = fone;
            Obs = obs;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string CNPJ { get; set; }
        public string End { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set;}
        public string Fone { get; set; }
        public string Obs { get; set; }
    }
}

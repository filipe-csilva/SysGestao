using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao.Models
{
    [Table("[Product]")]
    public class Product
    {
        //public Product(int id, string name, string gTIN, string gramatura, float pCompra, float pCusto, float pVenda, string obs)
        //{
        //    Id = id;
        //    Name = name;
        //    GTIN = gTIN;
        //    Gramatura = gramatura;
        //    PCompra = pCompra;
        //    PCusto = pCusto;
        //    PVenda = pVenda;
        //    Obs = obs;
        //}

        public int Id { get; set; }
        public string Name { get; set; }
        public string GTIN { get; set; }
        public string Gramatura { get; set; }
        public float PCompra { get; set; }
        public float PCusto { get; set; }
        public float PVenda { get; set; }
        public string Obs { get; set; }
    }
}

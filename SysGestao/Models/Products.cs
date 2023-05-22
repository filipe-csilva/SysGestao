using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao.Models
{
    public class Products
    {
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

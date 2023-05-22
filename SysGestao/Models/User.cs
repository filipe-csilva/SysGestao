using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao.Models
{
    [Table("[User]")]
    public class User : Pessoa
    {
        public string Password { get; set; }
    }
}

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
        public User(int id, string name, string cpf, string fone, string obs, string password) : base(id, name, cpf, fone, obs)
        {
            Password = password;
        }

        public string Password { get; set; }
    }
}

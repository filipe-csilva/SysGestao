using SysGestao.Aplicacoes.Clientes;
using SysGestao.Menus;
using SysGestao.Menus.Clientes;

namespace SysGestao
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaClientes.Show();

            Console.ReadKey();
        }
    }
}
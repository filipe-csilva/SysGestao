using SysGestao.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao.Aplicacoes.Clientes
{
    public static class CadClientes
    {
        public static void Show()
        {
            Console.Clear();
            Layout.Show();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(39, 3);
            Console.Write("CADASTRO DE NOVO CLIENTE\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 4);

            var endArquivo = "usuarios.csv";

            using(var fluxodearquivo = new FileStream(endArquivo, FileMode.Create))
            {
                var crienteDados = "1,FILIPE PAULO,51034276050,083986332350";

                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(crienteDados);

                fluxodearquivo.Write(bytes, 0, bytes.Length);
            }
        }
        public static void CriarArquivo()
        {
            var endArquivo = "usuarios.csv";

            using (var fluxodearquivo = new FileStream(endArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxodearquivo))
            {
                escritor.WriteLine("2,HAILTON CAMELO,42384118641,083986335200");
            }
        }
    }
}

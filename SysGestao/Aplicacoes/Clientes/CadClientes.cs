using Caelum.Stella.CSharp.Format;
using SysGestao.Menus;
using System.Text;

namespace SysGestao
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

            using (var fluxoDeArquivo = new FileStream(endArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                escritor.WriteLine("2,HAILTON CAMELO,42384118641,083986335200");
            }
        }

        public static void TestaEscrita()
        {
            var endArquivo = "teste.txt";

            using (var fluxoDeArquivo = new FileStream(endArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                for (int i = 1;i <= 1000000; i++)
                {
                    escritor.WriteLine($"Linha {i}");
                    escritor.Flush();
                    Console.WriteLine($"Linha {i} foi escrita com sucesso tecle enter...");
                }
            }
        }

        public static void CriarArquivo2()
        {
            var endArquivo = "testeEscrita.csv";

            using (var fluxoDeArquivo = new FileStream(endArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                escritor.WriteLine(true);
                escritor.WriteLine(false);
                escritor.WriteLine(4545454545);
            }
            Console.WriteLine("Aplicação Finalizada...");
        }

        public static void CriarArquivo3()
        {
            var endArquivo = "testeEscrita.csv";

            using (var fs = new FileStream(endArquivo, FileMode.Create))
            using (var escritor = new BinaryWriter(fs))
            {
                escritor.Write(456);
                escritor.Write(546544);
                escritor.Write(4000.50);
                escritor.Write("Gustavo Lima");
            }
            Console.WriteLine("Aplicação Finalizada...");
        }

        public static void LerArquivo3()
        {
            var endArquivo = "testeEscrita.csv";

            using (var fs = new FileStream(endArquivo, FileMode.Open))
            using (var leitor = new BinaryReader(fs))
            {
                var agencia = leitor.ReadInt32();
                var numeroDaConta = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var titular = leitor.ReadString();

                Console.WriteLine(agencia + "/" + numeroDaConta);
            }
            Console.WriteLine("Aplicação Finalizada...");
        }
    }
}

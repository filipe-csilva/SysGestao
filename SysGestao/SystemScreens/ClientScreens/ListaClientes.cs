using Caelum.Stella.CSharp.Format;
using SysGestao.Models;
using SysGestao.SystemScreens.PrimaryScreens;

namespace SysGestao.SystemScreens.ClientScreens
{
    public static class ListaClientes
    {
        public static void Load()
        {
            Console.Clear();
            Layout.Load();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(42, 3);
            Console.Write("LISTA DE CLIENTES\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 4);
            Layout.LinhaMenu();
            Console.SetCursorPosition(3, 5);
            Console.Write("CÓDIGO");
            Console.SetCursorPosition(11, 5);
            Console.Write("|");
            Console.SetCursorPosition(23, 5);
            Console.Write("NOME COMPLETO");
            Console.SetCursorPosition(47, 5);
            Console.Write("|");
            Console.SetCursorPosition(55, 5);
            Console.Write("CPF");
            Console.SetCursorPosition(65, 5);
            Console.Write("|");
            Console.SetCursorPosition(70, 5);
            Console.Write("TELEFONE");
            Console.SetCursorPosition(82, 5);
            Console.Write("|");
            Console.SetCursorPosition(87, 5);
            Console.Write("OBSERVAÇÕES");
            Console.SetCursorPosition(0, 6);
            Layout.LinhaMenu();

            //var clientes = GetDadosClientes();

            var endArquivo = "clientes.txt";

            using (var fluxoDoArquivo = new FileStream(endArquivo, FileMode.Open))
            {
                //opção inicial

                //var numBytesLidos = -1;
                //var tamanhoArquivo = 1024;

                //var buffer = new byte[tamanhoArquivo];

                //while (numBytesLidos != 0)
                //{
                //    numBytesLidos = fluxoDoArquivo.Read(buffer, 0, tamanhoArquivo);
                //    Console.WriteLine($"Bytes lidos: {numBytesLidos}");
                //    EscreverBuffer(buffer, numBytesLidos);
                //}
                //fluxoDoArquivo.Close();

                var leitor = new StreamReader(fluxoDoArquivo);

                //var linha = leitor.ReadLine(); //ler uma linha

                //var texto = leitor.ReadToEnd();  //ler o arquivo por completo não é bom

                //var numero = leitor.Read(); // ler o primeiro byte da primeira linha

                int i = 7;

                while (!leitor.EndOfStream)
                {
                    //Mostra carregando de linha por linha
                    var linha = leitor.ReadLine();
                    var cliente = ConverteStringPCliente(linha);
                    //var msg = $"{cliente.Id}{cliente.Nome}{cliente.CPF}{cliente.Telefone}";
                    Console.SetCursorPosition(4, i);
                    Console.Write($"{cliente.Id:0000}");
                    Console.SetCursorPosition(11, i);
                    Console.Write("|");
                    Console.SetCursorPosition(14, i);
                    Console.Write($"{cliente.Name}");
                    Console.SetCursorPosition(47, i);
                    Console.Write("|");
                    Console.SetCursorPosition(49, i);
                    Console.Write($"{cliente.CPF}");
                    Console.SetCursorPosition(65, i);
                    Console.Write("|");
                    Console.SetCursorPosition(68, i);
                    Console.Write($"{cliente.Fone}");
                    Console.SetCursorPosition(82, i);
                    Console.Write("|");
                    Console.SetCursorPosition(84, i);
                    //Console.Write($"{cliente.obs}");
                    i++;
                }

                //Console.WriteLine(numero);
            }
        }

        static Client ConverteStringPCliente(string linha)
        {
            var campos = linha.Split(";");
            var id = campos[0];
            var nome = campos[1];
            var cpf = new CPFFormatter().Format(campos[2]);
            var telefone = campos[3];
            var obs = campos[4];

            var idParse = int.Parse(id);

            var resultado = new Client();
            return resultado;
        }

        //Opção inicial

        //static void EscreverBuffer(byte[] buffer, int bytesLidos)
        //{
        //    int i = 6;
        //    var utf8 = new UTF8Encoding();
        //    //foreach (var meuByte in buffer)
        //    //{
        //    //    Console.SetCursorPosition(5, i);
        //    //    Console.WriteLine(meuByte);
        //    //    i++;
        //    //}
        //    //Console.SetCursorPosition(5, i);
        //    var texto = utf8.GetString(buffer, 0, bytesLidos);
        //    Console.Write(texto);
        //}

        //conexao com o banco de dados
        //private static IEnumerable<DadosClientes> GetDadosClientes()
        //{
        //    using(var connection = new SqlConnection(connectionString: "server = 'localhost'; database = 'db_sysgestao'; user = 'root'; password = ''"))
        //    {
        //        return connection.Query<DadosClientes>(sql: "select * from tb_clientes");
        //    }
        //}

    }
}
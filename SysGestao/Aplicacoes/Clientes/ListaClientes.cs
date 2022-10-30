using SysGestao.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao.Aplicacoes.Clientes
{
    public static class ListaClientes
    {
        public static void Show()
        {
            Console.Clear();
            Layout.Show();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(5, 4);
            Console.Write("Lista de Clientes");
            Console.ForegroundColor = ConsoleColor.White;

            var endArquivo = "clientes.txt";
            var numBytesLidos = -1;
            var tamanhoArquivo = 1024;

            var fluxoDoArquivo = new FileStream(endArquivo, FileMode.Open);

            var buffer = new byte[tamanhoArquivo];
            
            while(numBytesLidos != 0)
            {
                numBytesLidos = fluxoDoArquivo.Read(buffer, 0, tamanhoArquivo);
                EscreverBuffer(buffer);
            }
            fluxoDoArquivo.Close();
        }

        static void EscreverBuffer(byte[] buffer)
        {
            int i = 6;
            var utf8 = new UTF8Encoding();
            //foreach (var meuByte in buffer)
            //{
            //    Console.SetCursorPosition(5, i);
            //    Console.WriteLine(meuByte);
            //    i++;
            //}
            Console.SetCursorPosition(5, 6);
            var texto = utf8.GetString(buffer);
            Console.Write(texto);
        }
    }
}

using Caelum.Stella.CSharp.Format;
using SysGestao.Models;
using SysGestao.Repository;
using SysGestao.SystemScreens.Clientes;
using SysGestao.SystemScreens.PrimaryScreens;
using System;

namespace SysGestao.SystemScreens.ClientScreens
{
    public class ListClientScreen
    {
        public static void Load()
        {
            Console.Clear();
            Layout.Load();
            WhiteOption();
            Divisor();
            List();
            Console.ReadKey();
            PrimaryClientScreen.Load();
        }

        public static void WhiteOption()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(51, 3);
            Console.Write("CONSULTA DE CLIENTES");
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
            Console.SetCursorPosition(56, 5);
            Console.Write("CPF");
            Console.SetCursorPosition(66, 5);
            Console.Write("|");
            Console.SetCursorPosition(71, 5);
            Console.Write("TELEFONE");
            Console.SetCursorPosition(83, 5);
            Console.Write("|");
            Console.SetCursorPosition(96, 5);
            Console.Write("OBSERVAÇÕES");
            Console.SetCursorPosition(0, 6);
            Layout.LinhaMenu();
        }

        private static void List()
        {
            var repository = new Repository<Client>(DataBase.Connection);
            var tags = repository.Get();
            int v = 7;
            foreach(var item in  tags )
            {
                Console.SetCursorPosition(3, v);
                Console.WriteLine($"{item.Id:000000}");
                Console.SetCursorPosition(13, v);
                Console.WriteLine(item.Name);
                Console.SetCursorPosition(50, v);
                string cpfFormatado = new CPFFormatter().Format(item.CPF);
                Console.WriteLine($"{cpfFormatado}");
                Console.SetCursorPosition(69, v);
                Console.WriteLine(item.Fone);
                Console.SetCursorPosition(86, v);
                Console.WriteLine(item.Obs);
                v++;
            }
        }
        public static void Divisor()
        {
            for(int v = 7; v <= 27; v++)
            {
                Console.SetCursorPosition(11, v);
                Console.Write("|");
                Console.SetCursorPosition(47, v);
                Console.Write("|");
                Console.SetCursorPosition(66, v);
                Console.Write("|");
                Console.SetCursorPosition(83, v);
                Console.Write("|");
            }
            
        }
    }
}

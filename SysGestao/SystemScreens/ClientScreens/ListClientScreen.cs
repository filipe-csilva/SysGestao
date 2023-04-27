using SysGestao.SystemScreens.PrimaryScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao.SystemScreens.ClientScreens
{
    public class ListClientScreen
    {
        public static void Load()
        {
            Console.Clear();
            Layout.Load();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(53, 3);
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
            Console.SetCursorPosition(96, 5);
            Console.Write("OBSERVAÇÕES");
            Console.SetCursorPosition(0, 6);
            Layout.LinhaMenu();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao.Menus
{
    public static class MenuPrincipal
    {
        public static void Show()
        {
            Console.Clear();
            MenuLayout.Show();

            WhiteOptions();

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 0:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default: MenuPrincipal.Show();
                    break;
            }
        }
        
        public static void WhiteOptions()
        {
            Console.SetCursorPosition(5, 5);
            Console.Write("Selecione uma das opções abaixo:");
            Console.SetCursorPosition(5, 7);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("1");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Clientes");
            Console.SetCursorPosition(5, 8);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("2");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Fornecedores");
            Console.SetCursorPosition(5, 9);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("3");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Produtos");
            Console.SetCursorPosition(5, 10);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("4");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Úsuarios");
            Console.SetCursorPosition(5, 12);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("0");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Sair");
            Console.SetCursorPosition(5, 15);
            Console.Write("Opção: ");
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}

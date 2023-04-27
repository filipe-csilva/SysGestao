using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysGestao.SystemScreens.PrimaryScreens;

namespace SysGestao.SystemScreens.Fornecedores
{
    public static class PrimarySupplierScreen
    {
        public static void Load()
        {
            Console.Clear();
            Layout.Load();

            WhiteOptionsfn1();

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Load();
                    break;
                case 2:
                    Load();
                    break;
                case 3:
                    Load();
                    break;
                case 4:
                    Load();
                    break;
                case 0:
                    PrimaryMainScreen.Load();
                    break;
                default:
                    Load();
                    break;
            }
        }

        public static void WhiteOptionsfn1()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(5, 4);
            Console.Write("Menu Fornecedor");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(5, 6);
            Console.Write("Selecione uma das opções abaixo:");
            Console.SetCursorPosition(5, 8);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("1");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Cadastrar");
            Console.SetCursorPosition(5, 9);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("2");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Editar");
            Console.SetCursorPosition(5, 10);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("3");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Deletar");
            Console.SetCursorPosition(5, 11);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("4");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Consultar");
            Console.SetCursorPosition(5, 13);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("0");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Retornar");
            Console.SetCursorPosition(5, 16);
            Console.Write("Opção: ");
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}

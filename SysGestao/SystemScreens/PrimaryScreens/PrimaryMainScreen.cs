using SysGestao.SystemScreens.Clientes;
using SysGestao.SystemScreens.Fornecedores;
using SysGestao.SystemScreens.Produtos;
using SysGestao.SystemScreens.Usuarios;

namespace SysGestao.SystemScreens.PrimaryScreens
{
    public static class PrimaryMainScreen
    {
        public static void Load()
        {
            Console.Clear();
            Layout.Load();

            WhiteOptions();

            var letra = Console.ReadKey().KeyChar;
            int option = (int)char.ToUpper(letra) - 64;

            switch (option)
            {
                case -16:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                case -15:
                    PrimaryClientScreen.Load();
                    break;
                case -14:
                    PrimarySupplierScreen.Load();
                    break;
                case -13:
                    PrimaryProductScreen.Load();
                    break;
                case -12:
                    PrimaryUserScreen.Load();
                    break;
                default:
                    Load();
                    break;
            }
        }

        public static void WhiteOptions()
        {
            Console.SetCursorPosition(5, 6);
            Console.Write("Selecione uma das opções abaixo:");
            Console.SetCursorPosition(5, 8);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("1");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Clientes");
            Console.SetCursorPosition(5, 9);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("2");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Fornecedores");
            Console.SetCursorPosition(5, 10);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("3");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Produtos");
            Console.SetCursorPosition(5, 11);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("4");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Úsuarios");
            Console.SetCursorPosition(5, 13);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("0");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - Sair");
        }
    }
}

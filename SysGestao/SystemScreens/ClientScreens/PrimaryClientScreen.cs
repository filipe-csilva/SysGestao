using SysGestao.SystemScreens.ClientScreens;
using SysGestao.SystemScreens.PrimaryScreens;

namespace SysGestao.SystemScreens.Clientes
{
    public static class PrimaryClientScreen
    {
        public static void Load()
        {
            Console.Clear();
            Layout.Load();

            WhiteOptionscl1();

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CadClientes.Load();
                    break;
                case 2:
                    Load();
                    break;
                case 3:
                    Load();
                    break;
                case 4:
                    ListaClientes.Load();
                    break;
                case 0:
                    PrimaryMainScreen.Load();
                    break;
                default:
                    Load();
                    break;
            }
        }

        public static void WhiteOptionscl1()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(5, 4);
            Console.Write("Menu Clientes");
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

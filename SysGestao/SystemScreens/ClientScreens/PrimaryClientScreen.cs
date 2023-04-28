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

            var letra = Console.ReadKey().KeyChar;
            int option = (int)char.ToUpper(letra) - 64;

            switch (option)
            {
                case -15:
                    CreateClientScreen.Load();
                    break;
                case -14:
                    UpdateClientScreen.Load();
                    break;
                case -13:
                    DeleteClientScreen.Load();
                    break;
                case -12:
                    ListClientScreen.Load();
                    break;
                case -16:
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
        }
    }
}

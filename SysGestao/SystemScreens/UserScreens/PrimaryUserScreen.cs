using SysGestao.SystemScreens.PrimaryScreens;
using SysGestao.SystemScreens.UserScreens;

namespace SysGestao.SystemScreens.Usuarios
{
    public static class PrimaryUserScreen
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
                case -15:
                    CreateUserScreen.Load();
                    break;
                case -14:
                    UpdateUserScreen.Load();
                    break;
                case -13:
                    DeleteUserScreen.Load();
                    break;
                case -12:
                    ListUserScreen.Load();
                    break;
                case -16:
                    PrimaryMainScreen.Load();
                    break;
                default:
                    Load();
                    break;
            }
        }

        public static void WhiteOptions()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(5, 4);
            Console.Write("Menu Úsuarios");
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

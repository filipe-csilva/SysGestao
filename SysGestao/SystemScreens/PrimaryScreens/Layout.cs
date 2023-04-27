namespace SysGestao.SystemScreens.PrimaryScreens
{
    public static class Layout
    {
        public static void Load()
        {
            //Configura o fundo do sistema
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.CursorVisible = false;

            DrawnScreen();
        }

        public static void DrawnScreen()
        {
            LinhaMenu();
            for (int lines = 0; lines < 27; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 117; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|\n");
            }
            LinhaMenu();

            Console.SetCursorPosition(38, 1);
            Console.WriteLine("SysGestão - SISTEMA DE GERENCIAMENTO COMERCIAL");
            Console.SetCursorPosition(0, 2);
            LinhaMenu();
        }
        public static void LinhaMenu()
        {
            Console.Write("+");
            for (int i = 0; i <= 117; i++)
            {
                Console.Write("-");
            }
            Console.Write("+\n");
        }
    }
}

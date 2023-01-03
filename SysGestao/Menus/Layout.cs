namespace SysGestao
{
    public static class Layout
    {
        public static void Show()
        {
            //Configura o fundo do sistema
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            DrawnScreen();
        }

        public static void DrawnScreen()
        {
            LinhaMenu();
            for (int lines = 0; lines < 25; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 100; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|\n");
            }
            LinhaMenu();

            Console.SetCursorPosition(27, 1);
            Console.WriteLine("SysGestão - SISTEMA DE GERENCIAMENTO COMERCIAL");
            Console.SetCursorPosition(0, 2);
            LinhaMenu();
        }
        public static void LinhaMenu()
        {
            Console.Write("+");
            for (int i = 0; i <= 100; i++)
            {
                Console.Write("-");
            }
            Console.Write("+\n");
        }
    }
}

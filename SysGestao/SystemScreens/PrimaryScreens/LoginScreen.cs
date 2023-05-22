using Caelum.Stella.CSharp.Validation;
using SysGestao.Models;
using SysGestao.Repository;
using System.Security;
using System.Text;

namespace SysGestao.SystemScreens.PrimaryScreens
{
    public class LoginScreen
    {
        public static void Load()
        {
            Console.Clear();
            Layout.Load();
            Title();
            WhiteOption();

            Console.CursorVisible = true;


            Console.SetCursorPosition(30, 6);
            int id = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(30, 8);
            var password = new StringBuilder();

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else if (keyInfo.Key == ConsoleKey.Backspace)
                {
                    if (password.Length > 0)
                    {
                        password.Remove(password.Length - 1, 1);
                        Console.Write("\b \b");
                    }
                }
                else if (keyInfo.KeyChar != '\u0000')
                {
                    password.Append(keyInfo.KeyChar);
                    Console.Write("*");
                }
            }

            string senha = password.ToString();

            var repository = new Repository<User>(DataBase.Connection);
            var item = repository.Get(id);

            if (senha == item.Password)
            {
                var session = new Session();
                session.Id = item.Id;
                session.Name = item.Name;
                session.Utilizar();

                PrimaryMainScreen.Load();
            }
            else
            {
                Console.SetCursorPosition(3, 12);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Usuário e password digitado são inválidos");
                Console.SetCursorPosition(3, 16);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Precione qualquer tecla para tentar novamente...");
                Console.WriteLine(password);
                Console.ReadKey();
                Load();
            }
        }

        public static void WhiteOption()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(3, 6);
            Console.Write("DIGITE O ID DO USUÁRIO:");
            Console.SetCursorPosition(3, 8);
            Console.Write("DIGITE SEU PASSWORD:");
        }

        public static void Title()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(53, 3);
            Console.Write("LOGIN NO SISTEMA");
        }
    }
}

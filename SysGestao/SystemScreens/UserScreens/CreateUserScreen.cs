using Caelum.Stella.CSharp.Validation;
using SysGestao.Models;
using SysGestao.Repository;
using SysGestao.SystemScreens.PrimaryScreens;
using SysGestao.SystemScreens.Usuarios;
using System.Text;

namespace SysGestao.SystemScreens.UserScreens
{
    public class CreateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Layout.Load();
            Title();
            WhiteOption();
            Console.CursorVisible = true;


            Console.SetCursorPosition(26, 6);
            string name = Console.ReadLine();
            Console.SetCursorPosition(26, 8);
            string cpf = Console.ReadLine();
            Console.SetCursorPosition(26, 10);
            string fone = Console.ReadLine();
            Console.SetCursorPosition(26, 12);
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

            string senha1 = password.ToString();

            Console.SetCursorPosition(26, 14);
            var repassword = new StringBuilder();

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else if (keyInfo.Key == ConsoleKey.Backspace)
                {
                    if (repassword.Length > 0)
                    {
                        repassword.Remove(password.Length - 1, 1);
                        Console.Write("\b \b");
                    }
                }
                else if (keyInfo.KeyChar != '\u0000')
                {
                    repassword.Append(keyInfo.KeyChar);
                    Console.Write("*");
                }
            }

            string senha2 = repassword.ToString();

            if (senha1 != senha2)
            {
                Console.SetCursorPosition(3, 18);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("O Password e o Re-Password não está igual");
                Console.SetCursorPosition(3, 20);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Precione qualquer tecla para tentar novamente...");
                Console.ReadKey();
                Load();
            }

            if (new CPFValidator().IsValid(cpf))
            {
                Create(new User
                {
                    Name = name,
                    CPF = cpf,
                    Fone = fone,
                    Password = senha1,
                    Obs = null
                });
            }
            else
            {
                Console.SetCursorPosition(3, 18);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("O CPF digitado não é válido");
                Console.SetCursorPosition(3, 20);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Precione qualquer tecla para tentar novamente...");
                Console.ReadKey();
                Load();
            }
        }

        public static void WhiteOption()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(3, 6);
            Console.Write("NOME COMPLETO:");
            Console.SetCursorPosition(3, 8);
            Console.Write("CPF:");
            Console.SetCursorPosition(3, 10);
            Console.Write("TELEFONE:");
            Console.SetCursorPosition(3, 12);
            Console.Write("Password:");
            Console.SetCursorPosition(3, 14);
            Console.Write("Re-Password:");
        }

        public static void Create(User item)
        {
            try
            {
                var repository = new Repository<User>(DataBase.Connection);
                repository.Create(item);
                Console.Clear();
                Layout.Load();
                Title();
                Console.SetCursorPosition(3, 6);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Usuário {item.Name} Cadastrado com sucesso!");
                Console.SetCursorPosition(3, 8);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Precione qualquer tecla para continuar!");
                Console.ReadKey();
                PrimaryUserScreen.Load();
            }
            catch (Exception ex)
            {
                Console.Clear();
                Layout.Load();
                Title();
                Console.SetCursorPosition(3, 6);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Não foi possível salvar a tag");
                Console.SetCursorPosition(3, 8);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Erro : {ex.Message}");
                Console.SetCursorPosition(3, 10);
                Console.Write("Precione qualquer tecla para continuar!");
                Console.ReadKey();
                PrimaryUserScreen.Load();
            }
        }

        public static void Title()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(51, 3);
            Console.Write("CADASTRO DE USUÁRIO");
        }
    }
}

﻿using Caelum.Stella.CSharp.Validation;
using SysGestao.Models;
using SysGestao.Repository;
using SysGestao.SystemScreens.Clientes;
using SysGestao.SystemScreens.PrimaryScreens;

namespace SysGestao.SystemScreens.ClientScreens
{
    public class CreateClientScreen
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

            if (new CPFValidator().IsValid(cpf))
            {
                Create(new Client
                {
                    Name = name,
                    CPF = cpf,
                    Fone = fone,
                    Obs = null
                });
            }
            else
            {
                Console.SetCursorPosition(3, 14);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("O CPF digitado não é válido");
                Console.SetCursorPosition(3, 16);
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
        }

        public static void Create(Client client)
        {
            try
            {
                var repository = new Repository<Client>(DataBase.Connection);
                repository.Create(client);
                Console.Clear();
                Layout.Load();
                Title();
                Console.SetCursorPosition(3, 6);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Criente {client.Name} Cadastrado com sucesso!");
                Console.SetCursorPosition(3, 8);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Precione qualquer tecla para continuar!");
                Console.ReadKey();
                PrimaryClientScreen.Load();
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
                PrimaryClientScreen.Load();
            }
        }

        public static void Title()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(51, 3);
            Console.Write("CADASTRO DE CLIENTES");
        }
    }
}

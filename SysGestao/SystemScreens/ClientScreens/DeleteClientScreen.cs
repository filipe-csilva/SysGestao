﻿using SysGestao.Models;
using SysGestao.Repository;
using SysGestao.SystemScreens.Clientes;
using SysGestao.SystemScreens.PrimaryScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao.SystemScreens.ClientScreens
{
    public class DeleteClientScreen
    {
        public static void Load()
        {
            Console.Clear();
            Layout.Load();
            Title();
            Console.CursorVisible = true;
            WhiteOption();
            var id = int.Parse(Console.ReadLine());
            Consulte(id);
        }

        public static void WhiteOption()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(3, 6);
            Console.Write("Informe o (ID) que deseja excluir: ");
            
        }

        public static void Title()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(51, 3);
            Console.Write("CADASTRO DE CLIENTES");
        }

        public static void Consulte(int id)
        {
            try
            {
                var repository = new Repository<Client>(DataBase.Connection);
                var item = repository.Get(id);
            
                Console.SetCursorPosition(3, 8);
                Console.Write($"Deseja excluir o cliente {item.Name}? [S]Sim [N]Não: ");
                var letra = Console.ReadKey().KeyChar;
                int option = (int)char.ToUpper(letra) - 64;

                if(option == 19)
                {
                    try
                    {
                        repository.Delete(id);
                        Console.SetCursorPosition(3, 10);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"O cliente {item.Name} foi excluido com sucesso!");
                        Console.SetCursorPosition(3, 12);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Pressione [ENTER] para continuar...");
                        Console.CursorVisible = false;
                        Console.ReadKey();
                        PrimaryClientScreen.Load();
                    }catch (Exception ex)
                    {
                        Console.SetCursorPosition(3, 10);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"Não foi possivel excluir o cliente {item.Name}");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(3, 12);
                        Console.WriteLine(ex.Message);
                        Console.SetCursorPosition(3, 14);
                        Console.CursorVisible = false;
                        Console.WriteLine("Pressione [ENTER] para continuar...");
                        Console.ReadKey();
                        PrimaryClientScreen.Load();
                    }
                }
                else if(option == 14)
                {
                    Console.SetCursorPosition(3, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Exclusão do cliente {item.Name} foi cancelada!");
                    Console.SetCursorPosition(3, 12);
                    Console.ForegroundColor= ConsoleColor.White;
                    Console.CursorVisible = false;
                    Console.WriteLine("Pressione [ENTER] para continuar...");
                    Console.ReadKey();
                    PrimaryClientScreen.Load();
                }
                else
                {
                    Console.SetCursorPosition(3, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Você digitou uma opção inválida!");
                    Console.SetCursorPosition(3, 12);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.CursorVisible = false;
                    Console.WriteLine("Para tentar novamente precione [ENTER]...");
                    Console.ReadKey();
                    Load();
                }
                PrimaryClientScreen.Load();
            }
            catch (Exception ex)
            {
                Console.SetCursorPosition(3, 8);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"(ID) informado já foi excluido ou não existe!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(3, 10);
                Console.WriteLine(ex.Message);
                Console.SetCursorPosition(3, 12);
                Console.WriteLine("Pressione [ENTER] para continuar...");
                Console.ReadKey();
                PrimaryClientScreen.Load();

            }
        }
    }
}

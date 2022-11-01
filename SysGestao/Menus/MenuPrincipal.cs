using SysGestao.Aplicacoes.Clientes;
using SysGestao.Menus.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao.Menus
{
    public static class MenuPrincipal
    {
        public static void Show()
        {
            Console.Clear();
            Layout.Show();

            WhiteOptions();

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 0:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                case 1:
                    CadClientes.Show();
                    break;
                case 2:
                    MenuFornecedor.Show();
                    break;
                case 3:
                    MenuProdutos.Show();
                    break;
                case 4:
                    MenuUsuarios.Show();
                    break;                
                default: MenuPrincipal.Show();
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
            Console.SetCursorPosition(5, 16);
            Console.Write("Opção: ");
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}

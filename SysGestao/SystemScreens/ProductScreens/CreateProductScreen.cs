using SysGestao.Models;
using SysGestao.Repository;
using SysGestao.SystemScreens.Fornecedores;
using SysGestao.SystemScreens.PrimaryScreens;

namespace SysGestao.SystemScreens.ProductScreens
{
    public class CreateProductScreen
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
            string gtin = Console.ReadLine();
            Console.SetCursorPosition(26, 10);
            string gramatura = Console.ReadLine();
            Console.SetCursorPosition(26, 12);
            float precoCompra = float.Parse(Console.ReadLine());
            Console.SetCursorPosition(26, 14);
            float precoCusto = float.Parse(Console.ReadLine());
            Console.SetCursorPosition(26, 16);
            float precoVenda = float.Parse(Console.ReadLine());

            if (name != "")
            {
                Create(new Product
                {
                    Name = name,
                    GTIN = gtin,
                    Gramatura = gramatura,
                    PCompra = precoCompra,
                    PCusto = precoCusto,
                    PVenda = precoVenda,
                    Obs = null
                });
            }
            else
            {
                Console.SetCursorPosition(3, 20);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("O GTIN digitado não é válido");
                Console.SetCursorPosition(3, 22);
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
            Console.Write("NOME DO PRODUTO:");
            Console.SetCursorPosition(3, 8);
            Console.Write("CODIGO DE BARRAS:");
            Console.SetCursorPosition(3, 10);
            Console.Write("GRAMATURA:");
            Console.SetCursorPosition(3, 12);
            Console.Write("PRECO DE COMPRA:");
            Console.SetCursorPosition(3, 14);
            Console.Write("PRECO DE CUSTO:");
            Console.SetCursorPosition(3, 16);
            Console.Write("PRECO DE VENDA:");
        }

        public static void Create(Product product)
        {
            try
            {
                var repository = new Repository<Product>(DataBase.Connection);
                repository.Create(product);
                Console.Clear();
                Layout.Load();
                Title();
                Console.SetCursorPosition(3, 6);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Produto {product.Name} Cadastrado com sucesso!");
                Console.SetCursorPosition(3, 8);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Precione qualquer tecla para continuar!");
                Console.ReadKey();
                PrimarySupplierScreen.Load();
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
                PrimarySupplierScreen.Load();
            }
        }

        public static void Title()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(49, 3);
            Console.Write("CADASTRO DE PRODUTOS");
        }
    }
}

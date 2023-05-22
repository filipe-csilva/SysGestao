using Caelum.Stella.CSharp.Validation;
using SysGestao.Models;
using SysGestao.Repository;
using SysGestao.SystemScreens.Fornecedores;
using SysGestao.SystemScreens.PrimaryScreens;

namespace SysGestao.SystemScreens.SupplierScreens
{
    public static class CreateSupplierScreen
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
            string cnpj = Console.ReadLine();
            Console.SetCursorPosition(26, 10);
            string endereco = Console.ReadLine();
            Console.SetCursorPosition(26, 12);
            string bairro = Console.ReadLine();
            Console.SetCursorPosition(26, 14);
            string cidade = Console.ReadLine();
            Console.SetCursorPosition(26, 16);
            string estado = Console.ReadLine();
            Console.SetCursorPosition(26, 18);
            string cep = Console.ReadLine();
            Console.SetCursorPosition(26, 20);
            string fone = Console.ReadLine();

            if (new CNPJValidator().IsValid(cnpj))
            {
                Create(new Supplier
                {
                    Name = name,
                    CNPJ = cnpj,
                    End = endereco,
                    Bairro = bairro,
                    Cidade = cidade,
                    Estado = estado,
                    Cep = cep,
                    Fone = fone,
                    Obs = null
                });
            }
            else
            {
                Console.SetCursorPosition(3, 24);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("O CNPJ digitado não é válido");
                Console.SetCursorPosition(3, 26);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Precione qualquer tecla para tentar novamente...");
                Console.ReadKey();
                Load();
            }
        }

        public static void WhiteOption()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(3, 6);
            Console.Write("NOME DO FORNECEDOR:");
            Console.SetCursorPosition(3, 8);
            Console.Write("CNPJ:");
            Console.SetCursorPosition(3, 10);
            Console.Write("ENDEREÇO:");
            Console.SetCursorPosition(3, 12);
            Console.Write("BAIRRO:");
            Console.SetCursorPosition(3, 14);
            Console.Write("CIDADE:");
            Console.SetCursorPosition(3, 16);
            Console.Write("ESTADO:");
            Console.SetCursorPosition(3, 18);
            Console.Write("CEP");
            Console.SetCursorPosition(3, 20);
            Console.Write("TELEFONE");
        }

        public static void Create(Supplier supplier)
        {
            try
            {
                var repository = new Repository<Supplier>(DataBase.Connection);
                repository.Create(supplier);
                Console.Clear();
                Layout.Load();
                Title();
                Console.SetCursorPosition(3, 6);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Fornecedor {supplier.Name} Cadastrado com sucesso!");
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
                Console.Write("Não foi possível salvar a tag");
                Console.SetCursorPosition(3, 8);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Erro : {ex.Message}");
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
            Console.Write("CADASTRO DE FORNECEDORES");
        }
    }
}

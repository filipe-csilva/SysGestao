namespace SysGestao
{
    public class DadosClientes
    {
        public int Id { get; }
        public string Nome { get; set; }
        public string CPF { get; }
        public string Telefone { get; set; }

        public DadosClientes(int id, string nome, string cpf, string telefone)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
        }
    }
}

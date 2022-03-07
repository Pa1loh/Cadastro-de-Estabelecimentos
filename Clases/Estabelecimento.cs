namespace Cadastro_de_Estabelecimentos.Clases
{
    public class Estabelecimento : EntidadeBase
    {
        private string Nome { get; set; }
        private string Telefone { get; set; }
        private string Endereco { get; set; }
        private string Rua { get; set; }
        private string Numero { get; set; }
        private bool IsDeletado { get; set; }
        private EstabelecimentoTipo Tipo { get; set; }
        public Estabelecimento(int id, string nome, string telefone, string endereco, string rua, string numero, EstabelecimentoTipo tipo)
        {
            this.Id = id;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Rua = rua;
            Numero = numero;
            Tipo = tipo;
            this.IsDeletado = false;
        }

        public override string ToString()
        {
            string Retorno = "";
            Retorno += $"Nome{this.Nome} " + Environment.NewLine;
            Retorno += $"Nome{this.Telefone} " + Environment.NewLine;
            Retorno += $"Nome{this.Endereco} " + Environment.NewLine;
            Retorno += $"Nome{this.Rua} " + Environment.NewLine;
            Retorno += $"Nome{this.Tipo} " + Environment.NewLine;

            return Retorno;
        }

        public string RetornaNome()
        {

            return this.Nome;
        }

        public int RetornaId()
        {
            return this.Id;

        }
        public void Exclui()
        {
            this.IsDeletado = true;
        }



    }
}
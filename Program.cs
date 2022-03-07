using Cadastro_de_Estabelecimentos.Clases;

namespace Cadastro_de_Estabelecimentos
{
    public class Program
    {

        static EstabelecimentoRepositorio repositorio = new EstabelecimentoRepositorio();


        public void Main()
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {

                switch (opcaoUsuario)
                {

                    case "1":
                        ListarEstabelecimento();
                        break;
                    case "2":
                        CadastrarEstabelecimento();
                        break;
                    case "3":
                        AtualizarEstabelecimento();
                        break;
                    case "4":
                        ExcluirEstabelecimento();

                        break;
                    case "5":
                        VisualizarEstabelecimento();

                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();

                }

                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private void ExcluirEstabelecimento()
        {
            Console.WriteLine("Informe o Id do Estabelecimento:");
            int IdEstabelecimento = int.Parse(Console.ReadLine());

            var EstabelecimentoApresentar = repositorio.Exclui(Estabelecimento[IdEstabelecimento]);

            Console.WriteLine("Estabelecimento Excluido com sucesso");
        }

        private void VisualizarEstabelecimento()
        {
            Console.WriteLine("Informe o Id do Estabelecimento:");
            int IdEstabelecimento = int.Parse(Console.ReadLine());

            var EstabelecimentoApresentar = repositorio.RetornaPorId(IdEstabelecimento);

            Console.WriteLine(EstabelecimentoApresentar);
        }

        private void AtualizarEstabelecimento()
        {


            Console.WriteLine("Informe o Id do Estabelecimento:");
            int IdEstabelecimento = int.Parse(Console.ReadLine());
            foreach (int i in Enum.GetValues(typeof(EstabelecimentoTipo)))
            {
                Console.WriteLine($"{i}-{Enum.GetName(typeof(EstabelecimentoTipo), 1)}");

            }

            Console.WriteLine("Digite o tipo do Estabelecimento entre as opções a cima: ");
            int tipoEstabelecimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Nome do Estabelecimento: ");
            string Nome = Console.ReadLine();

            Console.WriteLine("Digite o Telefone do Estabelecimento: ");
            string Telefone = Console.ReadLine();

            Console.WriteLine("Digite o Endereco do Estabelecimento: ");
            string Endereco = Console.ReadLine();

            Console.WriteLine("Digite a Rua do Estabelecimento: ");
            string Rua = Console.ReadLine();

            Console.WriteLine("Digite o Numero do Estabelecimento: ");
            string Numero = Console.ReadLine();

            Estabelecimento NovoEstabelecimento = new Estabelecimento(
                id: repositorio.ProximoId(),
                Nome, Telefone, Endereco, Rua, Numero, EstabelecimentoTipo.Tipo(tipoEstabelecimento));

            repositorio.Atualiza(IdEstabelecimento, NovoEstabelecimento);
        }

        private void CadastrarEstabelecimento()
        {
            Console.WriteLine("Inserir Estabelecimento:");
            foreach (int i in Enum.GetValues(typeof(EstabelecimentoTipo)))
            {
                Console.WriteLine($"{i}-{Enum.GetName(typeof(EstabelecimentoTipo), 1)}");

            }

            Console.WriteLine("Digite o tipo do Estabelecimento entre as opções a cima: ");
            int tipoEstabelecimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Nome do Estabelecimento: ");
            string Nome = Console.ReadLine();

            Console.WriteLine("Digite o Telefone do Estabelecimento: ");
            string Telefone = Console.ReadLine();

            Console.WriteLine("Digite o Endereco do Estabelecimento: ");
            string Endereco = Console.ReadLine();

            Console.WriteLine("Digite a Rua do Estabelecimento: ");
            string Rua = Console.ReadLine();

            Console.WriteLine("Digite o Numero do Estabelecimento: ");
            string Numero = Console.ReadLine();

            Estabelecimento NovoEstabelecimento = new Estabelecimento(
                id: repositorio.ProximoId(),
                Nome, Telefone, Endereco, Rua, Numero, EstabelecimentoTipo.Tipo(tipoEstabelecimento));

            repositorio.Insere(NovoEstabelecimento);



        }

        private void ListarEstabelecimento()
        {
            Console.WriteLine("Lista de Estabelecimentos");
            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum Estabelecimento Cadastrado");
                return;
            }

            foreach (var Estabelecimento in lista)
            {
                Console.WriteLine($"#ID{Estabelecimento.Id}: - {Estabelecimento.RetornaNome}");

            }
        }

        public static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Cadastro de Estabelecimentos");
            Console.WriteLine("Informe a opção desejada");

            Console.WriteLine("1- Listar Estabelecimentos");
            Console.WriteLine("2- Inserir novo Estabelecimento");
            Console.WriteLine("3- Atualizar Estabelecimento");
            Console.WriteLine("4- Excluir Estabelecimento");
            Console.WriteLine("5- Visualizar Estabelecimento");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;




        }
    }
}
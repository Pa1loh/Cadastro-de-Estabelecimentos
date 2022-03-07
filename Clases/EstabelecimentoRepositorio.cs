using Cadastro_de_Estabelecimentos.Clases;

namespace Cadastro_de_Estabelecimentos
{
    public class EstabelecimentoRepositorio : IRepositorio<Estabelecimento>
    {

        private List<Estabelecimento> ListadeEstabalecimentos = new List<Estabelecimento>();
        public void Atualiza(int id, Estabelecimento entidade)
        {
            ListadeEstabalecimentos[id] = entidade;
        }

        public void Exclui(int id)
        {
            ListadeEstabalecimentos[id].Exclui();
        }

        public void Insere(Estabelecimento entidade)
        {
            ListadeEstabalecimentos.Add(entidade);
        }

        public List<Estabelecimento> Lista()
        {
            return ListadeEstabalecimentos;
        }

        public int ProximoId()
        {
            return ListadeEstabalecimentos.Count();
        }

        public Estabelecimento RetornaPorId(int id)
        {
            return ListadeEstabalecimentos[id];
        }
    }


}
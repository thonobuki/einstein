using AE.Entidade;

namespace AE.Infra.Interface
{
  public interface IMedicoRepository
    {
        void add(Consulta consulta);

        Consulta find(int id);
    }
}

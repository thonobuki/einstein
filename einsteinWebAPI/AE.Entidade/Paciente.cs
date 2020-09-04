using System.ComponentModel.DataAnnotations;

namespace AE.Entidade
{
    public partial class Paciente
    {
        [Key]
        public int IDPACIENTE { get; set; }
        public int NOME { get; set; }
    }
}

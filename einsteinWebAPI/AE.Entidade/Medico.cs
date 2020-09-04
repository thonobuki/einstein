using System.ComponentModel.DataAnnotations;

namespace AE.Entidade
{
    public partial class Medico
    {
        [Key]
        public int IDMEDICO { get; set; }
        public int NOME { get; set; }
    }
}

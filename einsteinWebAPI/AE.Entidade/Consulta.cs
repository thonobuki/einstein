using System.ComponentModel.DataAnnotations;

namespace AE.Entidade
{
    public partial class Consulta
    {
        [Key]
        public int IDCONSULTA { get; set; }
        public int IDPACIENTE { get; set; }
        public int IDMEDICO { get; set; }
        public int DTDATA { get; set; }

    }
}

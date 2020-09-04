using Microsoft.EntityFrameworkCore;
using AE.Entidade;

namespace AE.Infra
{
   public partial class AEContext: DbContext
    {
        public AEContext(DbContextOptions<AEContext> options) : base(options)
        {

        }

        public DbSet<Medico> MEDICO { get; set; }
        public DbSet<Paciente> PACIENTE { get; set; }
        public DbSet<Consulta> CONSULTA { get; set; }

    }
}

using AE.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace AE.Infra.Interface
{
    public interface IPacienteRepository
    {
        void add(Consulta consulta);

        Consulta find(int id);
    }
}

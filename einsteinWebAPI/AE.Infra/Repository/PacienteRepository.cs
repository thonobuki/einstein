using System;
using System.Collections.Generic;
using System.Text;
using AE.Entidade;
using System.Linq;
using AE.Infra.Interface;
using Microsoft.EntityFrameworkCore;

namespace AE.Infra.Repository
{
    public class PacienteRepository: IPacienteRepository
    {

     private readonly AEContext _aeContext;

        public PacienteRepository(AEContext eaContext)
        {
            _aeContext = eaContext;
        }

        public void add(Consulta consulta)
        {
            if (_aeContext.CONSULTA.Count(c => c.DTDATA == consulta.DTDATA && c.IDMEDICO == consulta.IDMEDICO) == 0)
            {
                _aeContext.CONSULTA.Add(consulta);
                _aeContext.SaveChanges();
            }
        }

        public Consulta find(int id)
        {
            return _aeContext.CONSULTA.FirstOrDefault(u => u.IDMEDICO == id);
        }
    }
}

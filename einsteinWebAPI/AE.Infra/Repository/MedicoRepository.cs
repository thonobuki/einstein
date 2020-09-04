using System;
using System.Collections.Generic;
using System.Text;
using AE.Entidade;
using System.Linq;
using AE.Infra.Interface;

namespace AE.Infra.Repository
{
    public class MedicoRepository: IMedicoRepository
    {
        private readonly AEContext _aeContext;

        public MedicoRepository(AEContext aeContext)
        {
            _aeContext = aeContext;
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

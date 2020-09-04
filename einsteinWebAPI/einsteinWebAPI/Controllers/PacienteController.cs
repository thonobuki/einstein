using AE.Entidade;
using AE.Infra.Interface;
using Microsoft.AspNetCore.Mvc;
using System;

namespace einsteinWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PacienteController: Controller
    {
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteController(IPacienteRepository _pacienteRepo)
        {
            _pacienteRepository = _pacienteRepo;
        }

        [HttpGet("{id}", Name = "GetConsulta")]
        public ActionResult GetByID(int id)
        {
            var consulta = _pacienteRepository;
            if (consulta == null)
            {
                return NotFound();
            }

            return new ObjectResult(consulta);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Consulta consulta)
        {
            if (consulta == null)
            {
                return BadRequest();
            }
            try
            {
                _pacienteRepository.add(consulta);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
}

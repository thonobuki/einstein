using AE.Entidade;
using AE.Infra.Interface;
using EA.Entidade;
using EA.Infra.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EA.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : Controller
    {
        private readonly IMedicoRepository _medicoRepository;

        public MedicoController(IMedicoRepository _medicoRepo)
        {
            _medicoRepository = _medicoRepo;
        }

        [HttpGet("{id}", Name = "GetConsulta")]
        public ActionResult GetByID(int id)
        {
            var consulta = _medicoRepository;
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
                _medicoRepository.add(consulta);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}


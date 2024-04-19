using ConsultasMedicas.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ConsultasMedicas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        private static List<Medico> medicos = new List<Medico>();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(medicos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Medico medico = medicos.Find(m => m.Id == id);
            if (medico == null)
            {
                return NotFound();
            }
            return Ok(medico);
        }

        [HttpPost]
        public IActionResult Create(Medico medico)
        {
            medico.Id = medicos.Count + 1;
            medicos.Add(medico);
            return CreatedAtAction(nameof(GetById), new { id = medico.Id }, medico);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Medico medicoAtualizado)
        {
            Medico medico = medicos.Find(m => m.Id == id);
            if (medico == null)
            {
                return NotFound();
            }
            medico.Nome = medicoAtualizado.Nome;
            medico.Especialidade = medicoAtualizado.Especialidade;
            medico.HorarioTrabalho = medicoAtualizado.HorarioTrabalho;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Medico medico = medicos.Find(m => m.Id == id);
            if (medico == null)
            {
                return NotFound();
            }
            medicos.Remove(medico);
            return NoContent();
        }
    }
}

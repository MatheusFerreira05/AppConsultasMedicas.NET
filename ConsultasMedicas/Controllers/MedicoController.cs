using Microsoft.AspNetCore.Mvc;
using ConsultasMedicas.Models;
using System;
using System.Collections.Generic;

namespace ConsultasMedicas.Controllers
{
    public class MedicoController : Controller
    {
        private static List<Medico> medicos = new List<Medico>();

        public IActionResult Index()
        {
            return View(medicos);
        }

        public IActionResult Details(int id)
        {
            Medico medico = medicos.Find(m => m.Id == id);
            if (medico == null)
            {
                return NotFound();
            }
            return View(medico);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Medico medico)
        {
            medico.Id = medicos.Count + 1;
            medicos.Add(medico);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Medico medico = medicos.Find(m => m.Id == id);
            if (medico == null)
            {
                return NotFound();
            }
            return View(medico);
        }

        [HttpPost]
        public IActionResult Edit(int id, Medico medicoAtualizado)
        {
            Medico medico = medicos.Find(m => m.Id == id);
            if (medico == null)
            {
                return NotFound();
            }
            medico.Nome = medicoAtualizado.Nome;
            medico.Especialidade = medicoAtualizado.Especialidade;
            medico.HorarioTrabalho = medicoAtualizado.HorarioTrabalho;
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Medico medico = medicos.Find(m => m.Id == id);
            if (medico == null)
            {
                return NotFound();
            }
            medicos.Remove(medico);
            return RedirectToAction("Index");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using ConsultasMedicas.Models;
using System;
using System.Collections.Generic;

namespace ConsultasMedicas.Controllers
{
    public class PacienteController : Controller
    {
        private static List<Paciente> pacientes = new List<Paciente>();

        public IActionResult Index()
        {
            return View(pacientes);
        }

        public IActionResult Details(int id)
        {
            Paciente paciente = pacientes.Find(p => p.Id == id);
            if (paciente == null)
            {
                return NotFound();
            }
            return View(paciente);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Paciente paciente)
        {
            paciente.Id = pacientes.Count + 1;
            pacientes.Add(paciente);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Paciente paciente = pacientes.Find(p => p.Id == id);
            if (paciente == null)
            {
                return NotFound();
            }
            return View(paciente);
        }

        [HttpPost]
        public IActionResult Edit(int id, Paciente pacienteAtualizado)
        {
            Paciente paciente = pacientes.Find(p => p.Id == id);
            if (paciente == null)
            {
                return NotFound();
            }
            paciente.Nome = pacienteAtualizado.Nome;
            paciente.DataNascimento = pacienteAtualizado.DataNascimento;
            paciente.Genero = pacienteAtualizado.Genero;
            paciente.HistoricoMedico = pacienteAtualizado.HistoricoMedico;
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Paciente paciente = pacientes.Find(p => p.Id == id);
            if (paciente == null)
            {
                return NotFound();
            }
            pacientes.Remove(paciente);
            return RedirectToAction("Index");
        }
    }
}

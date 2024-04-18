using Microsoft.AspNetCore.Mvc;
using ConsultasMedicas.Models;
using System;
using System.Collections.Generic;

namespace ConsultasMedicas.Controllers
{
    public class ConsultaController : Controller
    {
        private static List<Consulta> consultas = new List<Consulta>();

        public IActionResult Index()
        {
            return View(consultas);
        }

        public IActionResult Details(int id)
        {
            Consulta consulta = consultas.Find(c => c.Id == id);
            if (consulta == null)
            {
                return NotFound();
            }
            return View(consulta);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Consulta consulta)
        {
            consulta.Id = consultas.Count + 1;
            consultas.Add(consulta);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Consulta consulta = consultas.Find(c => c.Id == id);
            if (consulta == null)
            {
                return NotFound();
            }
            return View(consulta);
        }

        [HttpPost]
        public IActionResult Edit(int id, Consulta consultaAtualizada)
        {
            Consulta consulta = consultas.Find(c => c.Id == id);
            if (consulta == null)
            {
                return NotFound();
            }
            consulta.Data = consultaAtualizada.Data;
            consulta.Hora = consultaAtualizada.Hora;
            consulta.Medico = consultaAtualizada.Medico;
            consulta.Paciente = consultaAtualizada.Paciente;
            consulta.Motivo = consultaAtualizada.Motivo;
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Consulta consulta = consultas.Find(c => c.Id == id);
            if (consulta == null)
            {
                return NotFound();
            }
            consultas.Remove(consulta);
            return RedirectToAction("Index");
        }
    }
}

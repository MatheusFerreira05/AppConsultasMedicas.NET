using Microsoft.AspNetCore.Mvc;
using ConsultasMedicas.Models;
using System;
using System.Collections.Generic;

namespace ConsultasMedicas.Controllers
{
    public class EspecialidadeController : Controller
    {
        private static List<Especialidade> especialidades = new List<Especialidade>();

        public IActionResult Index()
        {
            return View(especialidades);
        }

        public IActionResult Details(int id)
        {
            Especialidade especialidade = especialidades.Find(e => e.Id == id);
            if (especialidade == null)
            {
                return NotFound();
            }
            return View(especialidade);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Especialidade especialidade)
        {
            especialidade.Id = especialidades.Count + 1;
            especialidades.Add(especialidade);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Especialidade especialidade = especialidades.Find(e => e.Id == id);
            if (especialidade == null)
            {
                return NotFound();
            }
            return View(especialidade);
        }

        [HttpPost]
        public IActionResult Edit(int id, Especialidade especialidadeAtualizada)
        {
            Especialidade especialidade = especialidades.Find(e => e.Id == id);
            if (especialidade == null)
            {
                return NotFound();
            }
            especialidade.Nome = especialidadeAtualizada.Nome;
            especialidade.Descricao = especialidadeAtualizada.Descricao;
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Especialidade especialidade = especialidades.Find(e => e.Id == id);
            if (especialidade == null)
            {
                return NotFound();
            }
            especialidades.Remove(especialidade);
            return RedirectToAction("Index");
        }
    }
}

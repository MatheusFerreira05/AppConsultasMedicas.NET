using Microsoft.AspNetCore.Mvc;
using ConsultasMedicas.Models;
using System;
using System.Collections.Generic;

namespace ConsultasMedicas.Controllers
{
    public class PacienteController : Controller
    {
        // Simulação de um banco de dados de pacientes
        private static List<Paciente> pacientes = new List<Paciente>();

        // Método para listar todos os pacientes
        public IActionResult Index()
        {
            return View(pacientes);
        }

        // Método para exibir detalhes de um paciente
        public IActionResult Details(int id)
        {
            Paciente paciente = pacientes.Find(p => p.Id == id);
            if (paciente == null)
            {
                return NotFound();
            }
            return View(paciente);
        }

        // Método para exibir o formulário de criação de paciente
        public IActionResult Create()
        {
            return View();
        }

        // Método para salvar um novo paciente
        [HttpPost]
        public IActionResult Create(Paciente paciente)
        {
            paciente.Id = pacientes.Count + 1; // Simplesmente incrementando o ID para esta simulação
            pacientes.Add(paciente);
            return RedirectToAction("Index");
        }

        // Método para exibir o formulário de edição de paciente
        public IActionResult Edit(int id)
        {
            Paciente paciente = pacientes.Find(p => p.Id == id);
            if (paciente == null)
            {
                return NotFound();
            }
            return View(paciente);
        }

        // Método para atualizar um paciente
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

        // Método para excluir um paciente
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

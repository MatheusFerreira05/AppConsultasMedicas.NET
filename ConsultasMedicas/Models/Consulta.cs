using System;
using System.ComponentModel.DataAnnotations;

namespace ConsultasMedicas.Models
{
    public class Consulta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A data da consulta é obrigatória.")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "A hora da consulta é obrigatória.")]
        public TimeSpan Hora { get; set; }

        public Medico Medico { get; set; } = new Medico();
        public Paciente Paciente { get; set; } = new Paciente();

        [Display(Name = "Motivo da Consulta")]
        public string Motivo { get; set; } = string.Empty;
    }
}

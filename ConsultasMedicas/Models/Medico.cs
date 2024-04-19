using System;
using System.ComponentModel.DataAnnotations;

namespace ConsultasMedicas.Models
{
    public class Medico
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do médico é obrigatório.")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "A especialidade do médico é obrigatória.")]
        public string Especialidade { get; set; } = string.Empty;

        [Display(Name = "Horário de Trabalho")]
        public string HorarioTrabalho { get; set; } = string.Empty;
    }
}

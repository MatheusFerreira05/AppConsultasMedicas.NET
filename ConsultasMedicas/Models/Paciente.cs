using System;
using System.ComponentModel.DataAnnotations;

namespace ConsultasMedicas.Models
{
    public class Paciente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do paciente é obrigatório.")]
        public string Nome { get; set; } = string.Empty;

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        public string Genero { get; set; } = string.Empty;

        [Display(Name = "Histórico Médico")]
        public string HistoricoMedico { get; set; } = string.Empty;
    }
}

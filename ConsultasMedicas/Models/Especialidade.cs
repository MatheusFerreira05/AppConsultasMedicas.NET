using System;
using System.ComponentModel.DataAnnotations;

namespace ConsultasMedicas.Models
{
    public class Especialidade
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da especialidade é obrigatório.")]
        public string Nome { get; set; } = string.Empty;

        [Display(Name = "Descrição")]
        public string Descricao { get; set; } = string.Empty;
    }
}

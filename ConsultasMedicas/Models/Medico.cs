using System;

namespace ConsultasMedicas.Models
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Especialidade { get; set; } = string.Empty;
        public string HorarioTrabalho { get; set; } = string.Empty;

        public Medico()
        {
            Nome = string.Empty;
            Especialidade = string.Empty;
            HorarioTrabalho = string.Empty;
        }
    }
}

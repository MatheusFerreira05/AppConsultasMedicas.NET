using System;

namespace ConsultasMedicas.Models
{
    public class Consulta
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }
        public Medico Medico { get; set; } = new Medico();
        public Paciente Paciente { get; set; } = new Paciente();
        public string Motivo { get; set; } = string.Empty;

        public Consulta()
        {
            // Inicializa as propriedades com valores padrão para evitar valores nulos
            Data = DateTime.MinValue;
            Hora = TimeSpan.Zero;
            Medico = new Medico();
            Paciente = new Paciente();
            Motivo = string.Empty;
        }
    }
}

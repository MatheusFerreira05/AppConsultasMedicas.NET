namespace ConsultasMedicas.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; }
        public string Genero { get; set; } = string.Empty;
        public string HistoricoMedico { get; set; } = string.Empty;

        public Paciente()
        {
            DataNascimento = DateTime.MinValue;
        }
    }
}

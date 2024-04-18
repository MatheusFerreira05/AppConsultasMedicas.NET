public class Consulta
{
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public TimeSpan Hora { get; set; }
    public Medico Medico { get; set; }
    public Paciente Paciente { get; set; }
    public string Motivo { get; set; }
}
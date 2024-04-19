using Microsoft.EntityFrameworkCore;
using ConsultasMedicas.Models;

namespace ConsultasMedicas.Models
{
    public class ConsultaMedicasContext : DbContext
    {
        public ConsultaMedicasContext(DbContextOptions<ConsultaMedicasContext> options)
            : base(options)
        {
        }

        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
    }
}

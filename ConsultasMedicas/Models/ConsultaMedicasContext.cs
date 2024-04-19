using Microsoft.EntityFrameworkCore;

namespace ConsultasMedicas.Models
{
    public class ConsultasMedicasContext : DbContext
    {
        public ConsultasMedicasContext(DbContextOptions<ConsultasMedicasContext> options) : base(options)
        {
        }

        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Consulta> Consultas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Medico>()
                .HasKey(m => m.Id);
            modelBuilder.Entity<Paciente>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Especialidade>()
                .HasKey(e => e.Id);
            modelBuilder.Entity<Consulta>()
                .HasKey(c => c.Id);
        }
    }
}

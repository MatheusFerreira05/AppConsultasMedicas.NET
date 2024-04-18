using System;

namespace ConsultasMedicas.Models
{
    public class Especialidade
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;

        public Especialidade()
        {
            // Inicializa as propriedades com valores padrão para evitar valores nulos
            Nome = string.Empty;
            Descricao = string.Empty;
        }
    }
}

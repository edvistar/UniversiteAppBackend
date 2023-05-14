using System.ComponentModel.DataAnnotations;

namespace UniversiteAppBackend.Models.DataModels
{
    public class Curso: BaseEntity
    {
        public string Nombre { get; set; } = string.Empty;
        [Required, MaxLength(280)]
        public string DescripcionCorta { get; set; } = string.Empty;
        public string DescripcionLarga { get; set; } = string.Empty;
        public string PublicoObjetivo { get; set; } = string.Empty;
        public string Objetivos { get; set; } = string.Empty;
        public enum Nivel { Basico, Intermedio, Avanzado }

    }
}

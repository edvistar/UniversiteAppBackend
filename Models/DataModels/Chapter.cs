using System.ComponentModel.DataAnnotations;

namespace UniversiteAppBackend.Models.DataModels
{
    public class Chapter: BaseEntity
    {
        [Required]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; } = new Course();
        [Required]
        public String List = string.Empty;

        
    }
}

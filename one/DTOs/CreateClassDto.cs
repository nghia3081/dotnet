using System.ComponentModel.DataAnnotations;

namespace one.DTOs
{
    public class CreateClassDto
    {
        public int Id { get; set; }
        [Required()]
        public string Name { get; set; } = null!;
        public int SubjectId { get; set; }
    }
}

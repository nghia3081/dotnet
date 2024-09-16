using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace one.Models
{
    public class Class
    {
        public Class()
        {
            Students = new HashSet<Student>();  
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; } = null!;
        public virtual ICollection<Student> Students { get; set; }
    }
}

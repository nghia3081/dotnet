using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace one.Models
{
    public class Subject
    {
        public Subject()
        {
            Classes = new HashSet<Class>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public virtual ICollection<Class> Classes { get; set; }
    }
}

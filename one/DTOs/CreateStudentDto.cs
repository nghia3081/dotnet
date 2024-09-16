using System.ComponentModel.DataAnnotations;

namespace one.DTOs
{
    public class CreateStudentDto
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Tên không được để trống")]
        public string StudentName { get; set; } = null!;
        public bool Gender { get; set; }
        public int ClassId { get; set; }
    }
}

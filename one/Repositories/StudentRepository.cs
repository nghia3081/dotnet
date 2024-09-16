using one.Models;

namespace one.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        readonly SchoolContext _context;
        public StudentRepository(SchoolContext context)
        {
            _context = context;
        }
        public Student GetLongestNameStudent()
        {
            return _context.Students.OrderByDescending(x => x.Name).First();
        }
    }
}

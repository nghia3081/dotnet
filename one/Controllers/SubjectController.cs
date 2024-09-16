using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using one.Models;

namespace one.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        readonly SchoolContext schoolContext;
        public SubjectController(SchoolContext schoolContext)
        {
            this.schoolContext = schoolContext;
        }
        [HttpPost]
        public Subject CreateSubject(Subject subject) {
            var createdSubject = this.schoolContext.Subjects.Add(subject).Entity;
            this.schoolContext.SaveChanges();
            return subject;

        }
    }
}

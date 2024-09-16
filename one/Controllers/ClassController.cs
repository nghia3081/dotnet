using Microsoft.AspNetCore.Mvc;
using one.DTOs;
using one.Models;

namespace one.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        readonly SchoolContext schoolContext;
        public ClassController(SchoolContext schoolContext)
        {
            this.schoolContext = schoolContext;
        }
        [HttpPost]
        public Class CreateClass(CreateClassDto createClassDto)
        {
            Class @class = new Class()
            {
                Name = createClassDto.Name,
                SubjectId = createClassDto.SubjectId,
            };
            var createdClass = this.schoolContext.Classes.Add(@class).Entity;
            this.schoolContext.SaveChanges();
            return createdClass;

        }
    }
}

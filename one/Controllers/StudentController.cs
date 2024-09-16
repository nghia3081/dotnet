using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using one.DTOs;
using one.Models;
using one.Repositories;

namespace one.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly SchoolContext schoolContext;
        private readonly IMapper mapper;
        readonly IStudentRepository studentRepository;
        public StudentController(SchoolContext schoolContext, IMapper mapper, IStudentRepository studentRepository)
        {
            this.schoolContext = schoolContext;
            this.mapper = mapper;
            this.studentRepository = studentRepository;
        }

        [HttpGet]
        public List<GetStudentDto> GetStudents()
        {
            List<Student> students = this.schoolContext.Students.ToList();
            return this.mapper.Map<List<GetStudentDto>>(students);
        }

        [HttpPost]
        public Student CreateStudent(CreateStudentDto createStudentDto)
        {
            Student student = mapper.Map<Student>(createStudentDto);
            var newStudent = schoolContext.Students.Add(student).Entity;
            schoolContext.SaveChanges();
            return newStudent;
        }
        [HttpGet("get-longest-name-student")]
        public Student GetStudentsByPost()
        {
            return this.studentRepository.GetLongestNameStudent();
        }
         
        //Get -> lấy data
        //Post -> tạo data create
        //Put -> Update data -> cập nhật hết
        //Delete -> Delete data
        //Patch -> Update data -> chỉ cập nhật 1 phần / 1 trường nào đó
    }
}

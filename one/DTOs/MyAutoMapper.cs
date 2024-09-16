using AutoMapper;
using one.Models;

namespace one.DTOs
{
    public class MyAutoMapper : Profile
    {
        public MyAutoMapper() { 
        
            this.CreateMap<Student, CreateStudentDto>().ForMember(x => x.StudentName, x => x.MapFrom(x => x.Name)).ReverseMap();
            this.CreateMap<Student, GetStudentDto>();
        }
    }
}

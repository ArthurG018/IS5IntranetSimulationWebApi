using AutoMapper;
using IS5.IntranetSimulation.WebApi.AplicationLayer.Dto;
using IS5.IntranetSimulation.WebApi.DomainLayer.Entity;

namespace IS5.IntranetSimulation.WebApi.CrossLayer.Mapper
{
    public class MappingsProfile:Profile
    {
        public MappingsProfile()
        {
            CreateMap<StudentDto, Student>().ForMember(destination => destination.Id, option => option.MapFrom(source => source.id)).ReverseMap();
            CreateMap<StudentDto, Student>().ForMember(destination => destination.UniversityCode, option => option.MapFrom(source => source.universityCode)).ReverseMap();
            CreateMap<StudentDto, Student>().ForMember(destination => destination.FullName, option => option.MapFrom(source => source.fullName)).ReverseMap();
            CreateMap<StudentDto, Student>().ForMember(destination => destination.RegistrationFormNumber, option => option.MapFrom(source => source.registrationFormNumber)).ReverseMap();
            CreateMap<StudentDto, Student>().ForMember(destination => destination.Semester, option => option.MapFrom(source => source.semester)).ReverseMap();
            CreateMap<StudentDto, Student>().ForMember(destination => destination.School, option => option.MapFrom(source => source.school)).ReverseMap();

            CreateMap<Professor, ProfessorDto>().ForMember(destination => destination.id, option => option.MapFrom(source => source.Id)).ReverseMap();
            CreateMap<Professor, ProfessorDto>().ForMember(destination => destination.fullName, option => option.MapFrom(source => source.FullName)).ReverseMap();
            CreateMap<Professor, ProfessorDto>().ForMember(destination => destination.dni, option => option.MapFrom(source => source.Dni)).ReverseMap();
        }
    }
}

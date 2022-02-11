using AutoMapper;
using Examen.Application.Person;
using Examen.Application.ViewModels;
using Examen.Domain.Models;

namespace Examen.Api.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<InsertPerson.Request, Person>();
            CreateMap<UpdatePerson.Request, Person>();

            CreateMap<Person, PersonViewModel>();
        }
    }
}

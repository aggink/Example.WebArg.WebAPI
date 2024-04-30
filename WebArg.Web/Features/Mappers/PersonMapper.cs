using AutoMapper;
using WebArg.Storage.Models;
using WebArg.Web.Features.DtoModels.Person;

namespace WebArg.Web.Features.Mappers;

/// <summary>
/// Настройка проецирования моделей <see cref="Person"/>, <see cref="PersonDto"/>, <see cref="EditPersonDto"/>
/// </summary>
public sealed class PersonMapper : Profile
{
    public PersonMapper()
    {
        CreateMap<PersonDto, Person>();
        CreateMap<Person, PersonDto>();

        CreateMap<EditPersonDto, Person>();
        CreateMap<Person, EditPersonDto>();
    }
}

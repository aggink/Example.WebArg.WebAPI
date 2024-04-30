using AutoMapper;
using WebArg.Storage.Models;
using WebArg.Web.Features.Studios.DtoModels;

namespace WebArg.Web.Features.Studios.Mappers;

/// <summary>
/// Настройка проецирования моделей <see cref="Studio"/>, <see cref="StudioDto"/>, <see cref="EditStudioDto"/>
/// </summary>
public sealed class StudioMapper : Profile
{
    public StudioMapper()
    {
        CreateMap<StudioDto, Studio>();
        CreateMap<Studio, StudioDto>();

        CreateMap<EditStudioDto, Studio>();
        CreateMap<Studio, EditStudioDto>();
    }
}

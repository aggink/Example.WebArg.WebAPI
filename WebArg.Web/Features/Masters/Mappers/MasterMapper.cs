using AutoMapper;
using WebArg.Storage.Models;
using WebArg.Web.Features.Masters.DtoModels;

namespace WebArg.Web.Features.Masters.Mappers;

/// <summary>
/// Настройка проецирования моделей <see cref="Master"/>, <see cref="MasterDto"/>, <see cref="EditMasterDto"/>
/// </summary>
public sealed class MasterMapper : Profile
{
    public MasterMapper()
    {
        CreateMap<MasterDto, Master>();
        CreateMap<Master, MasterDto>();

        CreateMap<EditMasterDto, Master>();
        CreateMap<Master, EditMasterDto>();
    }
}

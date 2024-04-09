using AutoMapper;
using WebArg.Storage.Models;
using WebArg.Web.Features.DtoModels.Studio;

namespace WebArg.Web.Features.Mappers
{
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
}

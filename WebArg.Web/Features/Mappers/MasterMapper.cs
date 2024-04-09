using AutoMapper;
using WebArg.Storage.Models;
using WebArg.Web.Features.DtoModels.Master;

namespace WebArg.Web.Features.Mappers
{
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
}

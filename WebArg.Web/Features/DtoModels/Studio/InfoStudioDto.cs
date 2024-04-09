using System;
using System.ComponentModel.DataAnnotations;
using WebArg.Web.Features.DtoModels.Master;
using WebArg.Web.Features.DtoModels.Person;

namespace WebArg.Web.Features.DtoModels.Studio
{
    public sealed record InfoStudioDto
    {
        [Display(Name = "Идентификатор студии")]
        public Guid IsnNode { get; init; }

        [Display(Name = "Название студии")]
        public string Name { get; init; }

        [Display(Name = "Местоположение студии")]
        public string Location { get; init; }

        [Display(Name = "Список мастеров")]
        public MasterDto[] Masters { get; init; }

        [Display(Name = "Список гостей")]
        public PersonDto[] Persons { get; init; }
    }
}

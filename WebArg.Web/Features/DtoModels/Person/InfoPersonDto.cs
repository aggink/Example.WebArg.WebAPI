using System;
using System.ComponentModel.DataAnnotations;
using WebArg.Web.Features.DtoModels.Master;
using WebArg.Web.Features.DtoModels.Studio;

namespace WebArg.Web.Features.DtoModels.Person
{
    public sealed record InfoPersonDto
    {
        [Display(Name = "Идентификатор гостя")]
        public Guid IsnNode { get; init; }

        [Display(Name = "Идентификатор студии")]
        public Guid IsnStudio { get; init; }

        [Display(Name = "Имя гостя")]
        public string Name { get; init; }

        [Display(Name = "Телефонный номер гостя")]
        public DateTime LastVisit { get; init; }

        [Display(Name = "Список студий")]
        public StudioDto Studio { get; init; }

        [Display(Name = "Список мастеров")]
        public MasterDto[] Masters { get; init; }
    }
}

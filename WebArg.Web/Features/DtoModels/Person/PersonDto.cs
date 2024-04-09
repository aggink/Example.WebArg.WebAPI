using System;
using System.ComponentModel.DataAnnotations;

namespace WebArg.Web.Features.DtoModels.Person
{
    public sealed record PersonDto
    {
        [Display(Name = "Идентификатор гостя")]
        public Guid IsnNode { get; init; }

        [Display(Name = "Идентификатор студии")]
        public Guid IsnStudio { get; init; }

        [Display(Name = "Имя гостя")]
        public string Name { get; init; }

        [Display(Name = "Дата последнего посещения гостя")]
        public DateTime LastVisit { get; init; }
    }
}

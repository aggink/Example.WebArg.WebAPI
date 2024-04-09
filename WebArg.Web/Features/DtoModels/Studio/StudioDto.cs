using System;
using System.ComponentModel.DataAnnotations;

namespace WebArg.Web.Features.DtoModels.Studio
{
    public sealed record StudioDto
    {
        [Display(Name = "Идентификатор студии")]
        public Guid IsnNode { get; init; }

        [Display(Name = "Название студии")]
        public string Name { get; init; }

        [Display(Name = "Место расположения студии")]
        public string Location { get; init; }

    }
}

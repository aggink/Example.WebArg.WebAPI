using System;
using System.ComponentModel.DataAnnotations;

namespace WebArg.Web.Features.DtoModels.Master
{
    public sealed record MasterDto
    {
        [Display(Name = "Идентификатор мастера")]
        public Guid IsnNode { get; init; }

        [Display(Name = "Имя мастера")]
        public string Name { get; init; }

        [Display(Name = "Квалификация мастера")]
        public string Qualification { get; init; }
    }
}

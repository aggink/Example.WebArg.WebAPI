using System;
using System.ComponentModel.DataAnnotations;
using WebArg.Web.Features.DtoModels.Person;
using WebArg.Web.Features.DtoModels.Studio;

namespace WebArg.Web.Features.DtoModels.Master
{
    public sealed record InfoMasterDto
    {
        [Display(Name = "Идентификато мастера")]
        public Guid IsnNode { get; init; }

        [Display(Name = "Имя мастера")]
        public string Name { get; init; }

        [Display(Name = "Квалификация мастера")]
        public string Qualification { get; init; }

        [Display(Name = "Список студий к которым прикреплён матсер")]
        public StudioDto[] Studios { get; init; }

        [Display(Name = "Список гостей к которым прикреплён матсер")]
        public PersonDto[] Persons { get; init; }
    }
}

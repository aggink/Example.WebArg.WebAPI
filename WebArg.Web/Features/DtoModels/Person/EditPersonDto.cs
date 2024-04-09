using System;
using System.ComponentModel.DataAnnotations;

namespace WebArg.Web.Features.DtoModels.Person
{
    public sealed record EditPersonDto
    {
        [Display(Name = "Идентификатор гостя")]
        [Required(ErrorMessageResourceName = "Required")]
        public Guid IsnNode { get; init; }

        [Display(Name = "Идентификатор студии")]
        [Required(ErrorMessageResourceName = "Required")]
        public Guid IsnStudio { get; init; }

        [Display(Name = "Имя гостя")]
        [Required(ErrorMessageResourceName = "Required")]
        [MaxLength(100, ErrorMessageResourceName = "MaxLength")]
        public string Name { get; init; }

        [Display(Name = "Телефонный номер гостя")]
        [Required(ErrorMessageResourceName = "Required")]
        public DateTime LastVisit { get; init; }
    }
}

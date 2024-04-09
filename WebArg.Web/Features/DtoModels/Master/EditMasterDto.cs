using System;
using System.ComponentModel.DataAnnotations;

namespace WebArg.Web.Features.DtoModels.Master
{
    public sealed record EditMasterDto
    {
        [Display(Name = "Идентификатор мастера")]
        [Required(ErrorMessageResourceName = "Required")]
        public Guid IsnNode { get; init; }

        [Display(Name = "Имя мастера")]
        [Required(ErrorMessageResourceName = "Required")]
        [MaxLength(100, ErrorMessageResourceName = "MaxLength")]
        public string Name { get; init; }

        [Display(Name = "Квалификация мастера")]
        [Required(ErrorMessageResourceName = "Required")]
        [MaxLength(100, ErrorMessageResourceName = "MaxLength")]
        public string Qualification { get; init; }
    }
}

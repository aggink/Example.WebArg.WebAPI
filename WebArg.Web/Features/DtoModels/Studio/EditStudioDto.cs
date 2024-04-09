using System;
using System.ComponentModel.DataAnnotations;

namespace WebArg.Web.Features.DtoModels.Studio
{
    public sealed record EditStudioDto
    {
        [Display(Name = "Идентификатор студии")]
        [Required(ErrorMessageResourceName = "Required")]
        public Guid IsnNode { get; init; }

        [Display(Name = "Название студии")]
        [Required(ErrorMessageResourceName = "Required")]
        [MaxLength(100, ErrorMessageResourceName = "MaxLength")]
        public string Name { get; init; }

        [Display(Name = "Местоположение")]
        [Required(ErrorMessageResourceName = "Required")]
        [MaxLength(100, ErrorMessageResourceName = "MaxLength")]
        public string Location { get; init; }
    }
}

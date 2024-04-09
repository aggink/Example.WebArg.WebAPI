using System;
using System.ComponentModel.DataAnnotations;

namespace WebArg.Web.Features.DtoModels.Studio
{
    public sealed record SetBindWithMasterDto
    {
        [Display(Name = "Идентификатор студии")]
        [Required(ErrorMessageResourceName = "Required")]
        public Guid IsnStudio { get; init; }

        [Display(Name = "Идентификатор мастера")]
        [Required(ErrorMessageResourceName = "Required")]
        public Guid IsnMaster { get; init; }
    }
}

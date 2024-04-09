using System;
using System.ComponentModel.DataAnnotations;

namespace WebArg.Web.Features.DtoModels.Master
{
    public sealed record SetBindWithPersonDto
    {
        [Display(Name = "Идентификатор мастера")]
        [Required(ErrorMessageResourceName = "Required")]
        public Guid IsnMaster { get; init; }

        [Display(Name = "Идентификатор гостя")]
        [Required(ErrorMessageResourceName = "Required")]
        public Guid IsnPerson { get; init; }
    }
}

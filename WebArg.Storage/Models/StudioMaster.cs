using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebArg.Storage.Models
{
    [Index(nameof(IsnStudio), nameof(IsnMaster))]
    [PrimaryKey(nameof(IsnStudio), nameof(IsnMaster))]
    public class StudioMaster
    {
        [ForeignKey(nameof(Studio)), Required]
        public Guid IsnStudio { get; set; }

        [ForeignKey(nameof(Master)), Required]
        public Guid IsnMaster { get; set; }

        public virtual Studio Studio { get; set; }

        public virtual Master Master { get; set; }
    }
}

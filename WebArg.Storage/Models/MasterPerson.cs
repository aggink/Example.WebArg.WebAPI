using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebArg.Storage.Models
{
    [Index(nameof(IsnMaster), nameof(IsnPerson))]
    [PrimaryKey(nameof(IsnMaster), nameof(IsnPerson))]
    public class MasterPerson
    {
        [ForeignKey(nameof(Master)), Required]
        public Guid IsnMaster { get; set; }

        [ForeignKey(nameof(Person)), Required]
        public Guid IsnPerson { get; set; }

        public virtual Master Master { get; set; }

        public virtual Person Person { get; set; }
    }
}

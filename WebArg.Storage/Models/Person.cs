using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebArg.Storage.Models
{
    public class Person
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid IsnNode { get; set; }

        [ForeignKey(nameof(Studio))]
        public Guid IsnStudio { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(100)]
        public DateTime LastVisit { get; set; }

        public virtual Studio Studio { get; set; }

        [InverseProperty(nameof(MasterPerson.Person))]
        public virtual ICollection<MasterPerson> PersonMasters { get; set; }
    }
}

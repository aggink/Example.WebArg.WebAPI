using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebArg.Storage.Models
{
    public class Studio
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid IsnNode { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(100)]
        public string Location { get; set; }

        [InverseProperty(nameof(Person.Studio))]
        public virtual ICollection<Person> Persons { get; set; }

        [InverseProperty(nameof(StudioMaster.Studio))]
        public virtual ICollection<StudioMaster> StudioMasters { get; set; }
    }
}

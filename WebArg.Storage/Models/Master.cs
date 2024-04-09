using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebArg.Storage.Models
{
    public class Master
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid IsnNode { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(100)]
        public string Qualification { get; set; }

        [InverseProperty(nameof(StudioMaster.Master))]
        public virtual ICollection<StudioMaster> MasterStudios { get; set; }

        [InverseProperty(nameof(MasterPerson.Master))]
        public virtual ICollection<MasterPerson> MasterPersons { get; set; }
    }
}

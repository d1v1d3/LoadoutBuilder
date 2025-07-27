using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using LoadoutBuilder.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadoutBuilder.Data.Models
{
    public class Camo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(ValidationConstants.Camo.NameMaxLength)]
        public string Name { get; set; }
        [StringLength(ValidationConstants.Camo.DescriptionMaxLength)]
        public string? Description { get; set; }
        public virtual ICollection<WeaponSlot> WeaponSlots { get; set; } = new HashSet<WeaponSlot>();
    }
}

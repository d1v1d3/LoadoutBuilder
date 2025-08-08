using LoadoutBuilder.Common;
using LoadoutBuilder.Data.Models.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadoutBuilder.Data.Models
{
    public class Camo : ISoftDeletable
    {
        [Key]
        public int Id { get; set; }
        [StringLength(ValidationConstants.Camo.NameMaxLength)]
        public string Name { get; set; }
        [StringLength(ValidationConstants.Camo.DescriptionMaxLength)]
        public string? Description { get; set; }
        public bool IsDeleted { get; set; } = false;
        public virtual ICollection<WeaponSlot> WeaponSlots { get; set; } = new HashSet<WeaponSlot>();
    }
}

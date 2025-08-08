using LoadoutBuilder.Common;
using LoadoutBuilder.Data.Models.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadoutBuilder.Data.Models
{
    public class Weapon : ISoftDeletable
    {
        [Key]
        public int Id { get; set; }
        [StringLength(ValidationConstants.Weapon.NameMaxLength)]
        public string Name { get; set; }
        [StringLength(ValidationConstants.Weapon.DescriptionMaxLength)]
        public string? Description { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int CotegoryId { get; set; }
        [ForeignKey(nameof(CotegoryId))]
        public virtual Category Category { get; set; }
        public virtual ICollection<WeaponSlot> WeaponSlots { get; set; } = new HashSet<WeaponSlot>();
    }
}

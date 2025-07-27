using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoadoutBuilder.Common;

namespace LoadoutBuilder.Data.Models
{
    public class Sight
    {
        [Key]
        public int Id { get; set; }
        [StringLength(ValidationConstants.Sight.TypeMaxLength)]
        public string Type { get; set; }
        public Range Range { get; set; }
        public ICollection<SightCategory> SightCategories { get; set; }
        public virtual ICollection<WeaponSlot> WeaponSlots { get; set; } = new HashSet<WeaponSlot>();
    }
    public enum Range
    {
        Short,
        Medium,
        Long
    }
}

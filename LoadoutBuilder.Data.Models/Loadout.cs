using LoadoutBuilder.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadoutBuilder.Data.Models
{
    public class Loadout
    {
        [Key]
        public int Id { get; set; }
        [StringLength(ValidationConstants.Loadout.NameMaxLength)]
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now; 
        public DateTime ModifiedOn { get; set; } = DateTime.Now;
        public virtual ICollection<WeaponSlot> WeaponSlots { get; set; } = new HashSet<WeaponSlot>();
        public string UserId { get; set; }
        [Required]
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadoutBuilder.Data.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public int CotegoryId { get; set; }
        [ForeignKey(nameof(CotegoryId))]
        public virtual Category Category { get; set; }
        public virtual ICollection<WeaponCamo> WeaponCamos { get; set; } = new HashSet<WeaponCamo>();
    }
}

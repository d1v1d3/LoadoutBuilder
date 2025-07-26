using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadoutBuilder.Data.Models
{
    public class Loadout
    {
        public int Id { get; set; }
        public virtual ICollection<WeaponCamo> Weapons { get; set; } = new HashSet<WeaponCamo>();
    }
}

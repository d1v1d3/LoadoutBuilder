using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadoutBuilder.Data.Models
{
    public class WeaponCamo
    {
        public int WeaponId { get; set; }
        [ForeignKey(nameof(WeaponId))]
        public Weapon Weapon { get; set; }
        public int CamoId { get; set; }
        [ForeignKey(nameof(CamoId))]
        public Camo Camo { get; set; }
    }
}

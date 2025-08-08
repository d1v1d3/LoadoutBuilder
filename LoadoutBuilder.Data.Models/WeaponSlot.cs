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
    public class WeaponSlot : ISoftDeletable
    {
        [Key]
        public int Id { get; set; }
        public int LoadoutId { get; set; }
        public Order Type { get; set; }
        [ForeignKey(nameof(LoadoutId))]
        public Loadout Loadout { get; set; }
        public int WeaponId { get; set; }
        [ForeignKey(nameof(WeaponId))]
        public Weapon Weapon { get; set; }
        public int? CamoId { get; set; }
        [ForeignKey(nameof(CamoId))]
        public Camo? Camo { get; set; }
        public int? SightId { get; set; }
        [ForeignKey(nameof(SightId))]
        public Sight? Sight { get; set; }
        public bool IsDeleted { get; set; } = false;
        public enum Order
        {
            Primary = 1,
            Secondary = 2
        }
    }
    
}

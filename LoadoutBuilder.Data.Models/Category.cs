using LoadoutBuilder.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadoutBuilder.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [StringLength(ValidationConstants.Category.NameMaxLength)]
        public string Name { get; set; }
        public virtual ICollection<Weapon> Weapons { get; set; }
        public virtual ICollection<SightCategory> SightCategories { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LoadoutBuilder.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Loadout> Loadouts { get; set; } = new HashSet<Loadout>();
    }
}

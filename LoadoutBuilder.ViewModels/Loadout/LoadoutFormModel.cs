using LoadoutBuilder.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadoutBuilder.ViewModels.Loadout
{
    public class LoadoutFormModel
    {
        [Required(ErrorMessage = ValidationMessages.Loadout.NameRequiredMessage)]
        [StringLength(ValidationConstants.Loadout.NameMaxLength, MinimumLength = ValidationConstants.Loadout.NameMinLength, ErrorMessage = ValidationMessages.Loadout.NameLengthMessage)]
        public string Name { get; set; }
        public string? UserId { get; set; }
    }
}

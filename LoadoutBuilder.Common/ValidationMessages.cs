using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadoutBuilder.Common
{
    public static class ValidationMessages
    {
        public static class Weapon
        {
            public const string NameRequiredMessage = "Weapon name is required.";
            public const string NameLengthMessage = "Name must be between 2 and 30 characters.";
            public const string DescriptionLengthMessage = "Description is too long.";
        }
        public static class Camo
        {
            public const string NameRequiredMessage = "Camo name is required.";
            public const string NameLengthMessage = "Name must be between 2 and 40 characters.";
            public const string DescriptionLengthMessage = "Description is too long.";
        }
        public static class Category
        {
            public const string NameRequiredMessage = "Category name is required.";
            public const string NameLengthMessage = "Name must be between 2 and 30 characters.";
        }
        public static class Sight
        {
            public const string TypeRequiredMessage = "Sight type is required.";
            public const string TypeLengthMessage = "Type must be between 2 and 30 characters.";
        }
        public static class Loadout
        {
            public const string NameRequiredMessage = "Loadout name is required.";
            public const string NameLengthMessage = "Name must be between 1 and 40 characters.";
        }
    }
}

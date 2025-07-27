using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadoutBuilder.Common
{
    public static class ValidationConstants
    {
        public static class Weapon
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 30;
            public const int DescriptionMinLength = 0;
            public const int DescriptionMaxLength = 200;
        }
        public static class Camo
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 40;
            public const int DescriptionMinLength = 0;
            public const int DescriptionMaxLength = 200;
        }
        public static class Category
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 30;
        }
        public static class Sight
        {
            public const int TypeMinLength = 2;
            public const int TypeMaxLength = 30;
        }
    }
}

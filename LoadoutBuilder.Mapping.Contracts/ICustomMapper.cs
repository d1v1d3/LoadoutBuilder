using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadoutBuilder.Mapping.Contracts
{
    public interface ICustomMapper
    {
        TDestination Map<TSource, TDestination>(TSource source);
    }
}

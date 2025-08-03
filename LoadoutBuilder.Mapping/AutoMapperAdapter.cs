using AutoMapper;
using LoadoutBuilder.Mapping.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadoutBuilder.Mapping
{
    public class AutoMapperAdapter : ICustomMapper
    {
        private readonly IMapper _mapper;
        public AutoMapperAdapter(IMapper mapper)
        {
            _mapper = mapper;
        }

        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return _mapper.Map<TDestination>(source);
        }
    }
}

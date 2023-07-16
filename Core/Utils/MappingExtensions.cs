using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utils
{
    public static class MappingExtensions
    {
        public static List<TDestination> Map<TSource, TDestination>(this IEnumerable<TSource> source, IMapper mapper)
        {
            return source.Select(item => mapper.Map<TSource, TDestination>(item)).ToList();
        }
    }
}

using Registar.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Registar.Mappers
{
    public static class MapperManager
    {
        static IMapper Mapper { get; set; }

        public static void RegisterMapper(IMapper mapper)
        {
            Mapper = mapper;
        }

        public static void CreateMap<TSource, TDestination>()
        {
            Mapper.CreateMap<TSource, TDestination>();
        }

        public static TDestination GetModel<TDestination>(object source)
        {
            return Mapper.getMappedModel<TDestination>(source);
        }
    }
}
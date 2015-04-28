using Registar.DomainModel;
using Registar.Interfaces;
using Registar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Registar.Mappers
{
    public class DefaultMapper : IMapper
    {
        public void CreateMap<TSource, TDestination>()
        {
            AutoMapper.Mapper.CreateMap<TSource, TDestination>();
        }


        public TDestination getMappedModel<TDestination>(object source)
        {
            return AutoMapper.Mapper.Map<TDestination>(source);
        }
    }
}
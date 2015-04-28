using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.Interfaces
{
    public interface IMapper
    {
        void CreateMap<TDestination, TSource>();

        TDestination getMappedModel<TDestination>(object source);
    }
}

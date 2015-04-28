
using Registar.Common.Interfaces;
using Registar.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.DataLayer.Interfaces
{
    public interface IRegistarContext : IContext
    {
        IDbSet<Bike> Bikes { get; set; }
    }
}

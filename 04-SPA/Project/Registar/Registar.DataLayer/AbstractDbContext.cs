using Registar.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.DataLayer
{
    public class AbstractDbContext : DbContext, IDbContext 
    {
        public DbSet<Bike> Bikes { get; set; }

        public AbstractDbContext(string connString) : base(connString)
        {

        }
    }
}


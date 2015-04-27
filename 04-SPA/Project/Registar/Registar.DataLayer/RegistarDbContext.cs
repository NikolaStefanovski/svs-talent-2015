using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.DomainModel;
using Registar.DataLayer.Interfaces;

namespace Registar.DataLayer
{
    public class RegistarDbContext : DbContext, IRegistarContext
    {
        DbSet<Bike> Bikes;

        public RegistarDbContext() : base("RegistarDb")
        {
            this.Bikes = this.Set<Bike>();
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new BikeConfiguration());
            
        }
    }
}

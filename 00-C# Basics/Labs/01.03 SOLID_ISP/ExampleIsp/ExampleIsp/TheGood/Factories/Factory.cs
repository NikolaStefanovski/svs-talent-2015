using ExampleIsp.TheGood.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheGood.Factories
{
    public abstract class Factory : IFactory
    {
        public int Shift { get; private set; }

        public virtual int StartShift()
        {
            this.Shift = Shift + 1;
            if (this.Shift > 3)
            {
                this.Shift = 3;
                throw new Exception("Maximum 3 shifts can be started!");
            }
            Console.WriteLine("Shift started!");
            return this.Shift;
        }

        public virtual int CloseShift()
        {
            this.Shift = Shift - 1;
            if (this.Shift < 0)
            {
                this.Shift = 0;
                throw new Exception("Atleast one shift needs to be started in order to close it!");
            }

            Console.WriteLine("Shift closed!");
            return this.Shift;
        }


        public abstract int StartProductionLane();


        public abstract int StopProductionLane();


        public abstract int ProduceBody();


        public abstract int ProduceEngine();


        public abstract int ProduceGears();


        public abstract int ProduceHeadLamps();


        public abstract int ProduceElectronics();


        public abstract int Paint(int paintColour);       
    }
}

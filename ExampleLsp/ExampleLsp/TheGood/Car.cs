using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLsp.TheGood
{
    public class Car : IOperate, IInform
    {
        public virtual void OperateVehicle()
        {
            Console.WriteLine("Operate the vehicle!");
        }

        public virtual void GetInfoForLater()
        {
            Console.WriteLine("Get info for vehicle!");
        }
    }
}

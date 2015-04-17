using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOcp
{
    public class Vehicle
    {
        public VehicleType Type { get; set; }

        public void OperateVehicle()
        {
            switch (Enum.GetName(typeof(VehicleType), Type))
            {
                case "Car": Console.WriteLine("Drive the car!");
                    break;
                case "Plane": Console.WriteLine("FLy the plane!");
                    break;
                case "Submarine": Console.WriteLine("Go underwater!");
                    break;
                default: Console.WriteLine("Operate the vehicle!");
                    break;
            }
        }
    }

    enum VehicleType
    {
        None, Car, Plane, Submarine
    }
}

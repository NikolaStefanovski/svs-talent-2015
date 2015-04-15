using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    public class AcmeCar
    {
        public LockState IsLocked { get; private set; }

        public void Lock()
        {
            try
            {
                //
                this.IsLocked = LockState.Locked;
                //log state change in computer
                Logger.ComputerLogChangeStateOnCloud("Car locked!");

            }
            catch (Exception)
            {
                Logger.ComputerLogChangeStateOnPhone("There was an error locking the car!");
            }
        }

        public void Unlock()
        {
            try
            {
                //
                this.IsLocked = LockState.Unlocked;
                //
                Logger.ComputerLogChangeStateOnCloud("Car unlocked!");
            }
            catch (Exception)
            {
                Logger.ComputerLogChangeStateOnPhone("There was an error unlocking the car!");
            }

        }
    }

    public enum LockState
    {
        Error = 0,
        Locked = 1,
        Unlocked = 2,

    }
}

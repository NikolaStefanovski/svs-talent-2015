using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    public class AcmeDipCar
    {
        private ILogger _logger;
        //private string _logInfo;

        public event EventHandler<string> OnStateChanged;
        public event EventHandler<string> OnFailureToChangeState;

        public LockState IsLocked { get; private set; }

        public AcmeDipCar(ILogger logger)
        {
            _logger = logger;
            if (_logger != null)
            {
                OnStateChanged += _logger.ComputerLogStateChanged;
                OnFailureToChangeState += _logger.ComputerLogException;
            }
        }  

        public void Lock()
        {
            try
            {             
                this.IsLocked = LockState.Locked;

                //log state change in computer
                OnStateChanged(this, "Car locked");
            }
            catch (Exception)
            {
                OnFailureToChangeState(this, "There was an error locking the car!");
            }
        }

        public void Unlock()
        {
            try
            {
                this.IsLocked = LockState.Unlocked;

                //log state change in computer
                OnStateChanged(this, "Car unlocked!");
            }
            catch (Exception)
            {
                OnFailureToChangeState(this, "There was an error unlocking the car!");
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

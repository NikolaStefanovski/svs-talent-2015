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
        private string _logInfo;

        public event EventHandler<string> OnStateChanged;
        public event EventHandler<string> OnFailureToChangeState;

        public string LogInfo
        {
            get { return _logInfo; }
            set { _logInfo = value; }
        }

        public LockState IsLocked { get; private set; }

        public AcmeDipCar(string logInfo)
        {
            _logger = Logger.Instance;
            OnStateChanged += _logger.ComputerLogStateChanged;
        }

        void _logger_ComputerLogChangeState(object sender, string e)
        {
            throw new NotImplementedException();
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
            _logger = Logger.Instance;

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

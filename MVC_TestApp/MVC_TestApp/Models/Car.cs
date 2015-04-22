using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_TestApp.Models
{
    public class Car
    {
        private int _number;

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public Car(int number)
        {
            _number = number;
        }
    }
}
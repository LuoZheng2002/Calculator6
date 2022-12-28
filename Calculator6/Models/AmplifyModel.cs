using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator6.Models
{
    internal class AmplifyModel
    {
        private int _number1;
        private int _number2;
        public int Number1
        {
            get { return _number1; }
            set { if (_number1 != value)
                {
                    _number1 = value;
                    Number1Changed?.Invoke();
                }
            }
        }
        public int Number2
        {
            get { return _number2; }
            set
            {
                if (_number2 != value && _number2 != value + 1)
                {
                    _number2 = value;
                    Number2Changed?.Invoke();
                }
            }
        }
        public void CalculateNumber1(object obj) // The obj parameter is just used to fit the delegate format
        {
            Number1 = Number2 / 2;
        }
        public void CalculateNumber2(object obj)
        {
            Number2 = Number1 * 2;
        }
        public event Action Number1Changed;
        public event Action Number2Changed;
    }
}

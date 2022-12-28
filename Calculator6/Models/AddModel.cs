using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator6.Models
{
    internal class AddModel
    {
        public int Adder1 { get; set; }
        public int Adder2 { get; set; }
        private int _sum;
        public int Sum
        {
            get { return _sum; }
            set
            {
                if (_sum != value)
                {
                    _sum = value;
                    SumChanged?.Invoke();
                }
            }
        }
        public void Add(object obj) // the obj parameter is just used to fit the delegate format
        {
            Sum = Adder1 + Adder2;
        }
        public event Action SumChanged;
    }
}

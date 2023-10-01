using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Calculator
{
    public class Calculator
    {
        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }
        public int Subtract(int value1, int value2) {  return value1 - value2; }
        public int Multiply(int value1, int value2) { return value1 * value2; }
        public int Divide(int value1, int value2) { return value1 / value2; }
    }
}

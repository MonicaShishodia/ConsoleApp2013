using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2015ServiceLayer;

namespace ConsoleApp2015
{
    public class BusinessLayer : IValidations, ICalculate
    {
        public bool CheckEmptyNumbers(string value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                return false;
            else return true;
        }
        public bool CheckIfNumbers(string value)
        {
            double result;
            if (double.TryParse(value, out result))
                return true;
            else return false;
        }
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}

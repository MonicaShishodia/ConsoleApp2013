using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2015ServiceLayer
{
    public interface IValidations
    {
        bool CheckEmptyNumbers(string value);
        bool CheckIfNumbers(string value);
    }
    public interface ICalculate
    {
        int AddNumbers(int a, int b);
    }
}

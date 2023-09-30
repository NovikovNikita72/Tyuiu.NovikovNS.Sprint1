using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NovikovNS.Sprint1.Task7.V16.Lib
{
    public class DataService : ISprint1Task7V16
    {
        public double Calculate(double x)
        {
            double res = Math.Sin(Math.Sqrt(Math.Pow(x,2)))+Math.Cos(Math.Pow(x,2))/Math.Pow(3*x,2) - Math.Sin(Math.Pow(x , 2) - 1);
            return res;
        }
    }
}

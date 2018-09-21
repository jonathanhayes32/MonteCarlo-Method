using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo_Method
{
    class Hypotenuse
    {
        //step 2
        public double Hyp(double x, double y)
        {
            double part1 = 0;
            double part2 = 0;

            part1 = Math.Pow(x, 2) + Math.Pow(y, 2);

            part2 = Math.Sqrt(part1);
            return part2;
        }
    }
}

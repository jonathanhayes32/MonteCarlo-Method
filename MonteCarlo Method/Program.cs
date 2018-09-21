using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo_Method
{
    struct Mystruct
    {
        //step 1
        public double x, y;

        public Mystruct(double x, double y)
        {

            this.x = x;
            this.y = y;
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            //step 3
            int allPairs;
            Console.Write("Please enter total number of pairs: ");
            allPairs = Convert.ToInt32(Console.ReadLine());

            Mystruct[] points = new Mystruct[allPairs];
            Random rand = new Random();
            for (int i = 0; i < points.Length; i++)
            {

                double x = rand.NextDouble();
                double y = rand.NextDouble();
                points[i] = new Mystruct(x, y);

            }
            CountOverLaps(points);

        }
        //step 4
        public static int CountOverLaps(Mystruct[] points)
        {
            int overLapCount = 0;
            double piApprox = 0;

            Hypotenuse hypo = new Hypotenuse();
            for (int i = 0; i < points.Length; i++)
            {

                double distanceFromOrigin = hypo.Hyp(points[i].x, points[i].y);
                if (distanceFromOrigin <= 1)
                {
                    overLapCount++;
                }
            }
            piApprox = 4.0 * (overLapCount / points.Length);
            Console.WriteLine(overLapCount);
            Console.WriteLine(Math.Abs(piApprox - Math.PI));
            return overLapCount;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Library
{
    public class Square : Shape
    {
        private int sideA;
        private int sideB;
        private int sideC;
        public Square(int sideA, int sideB, int sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }
        public override double square()
        {
            double p = (sideA + sideB + sideC) / (double)2;
            return Math.Sqrt(p*(p-sideA)*(p-sideB)*(p-sideC));
        }
    }
}

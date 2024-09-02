using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Library
{
    public class Circle : Shape
    {
        private int radius;

        public Circle(int radius)=>
            this.radius = radius;

        public override double square() =>
            radius*2*Math.PI;
    }
}

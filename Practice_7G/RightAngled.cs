using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_7G
{
    class RightAngled : Pair
    {
        public int firstСathetus { get; set; }

        public int secondСathetus { get; set; }

        public RightAngled(int first, int second) : base(first, second)
        {
            firstСathetus = first;
            secondСathetus = second;
        }

        public double GetHypotenuse(RightAngled triangle)
        {
            return Math.Sqrt((triangle.firstСathetus * triangle.firstСathetus) + (triangle.secondСathetus * triangle.secondСathetus));
        }

        public long GetArea(RightAngled triangle)
        {
            return (triangle.secondСathetus * triangle.secondСathetus) / 2;
        }
    }
}

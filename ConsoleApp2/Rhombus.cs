using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFour
{
    class Rhombus : Quadrangle
    {
        public Rhombus(Point point1, Point point2, Point point3, Point point4) :
            base(point1, point2, point3, point4) { }

        public override bool IsValid()
        {
            if (!base.IsValid())
            {
                return false;
            }
            return (Sides[0].Length == Sides[1].Length && 
                Sides[2].Length == Sides[0].Length && 
                Sides[3].Length == Sides[0].Length);
        }
    }
}

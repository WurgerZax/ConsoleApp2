using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleFour
{
    class Quadrangle : Figure
    {
        public Quadrangle(Point point1, Point point2, Point point3, Point point4) :
            base(new List<Point>() { point1, point2, point3, point4 })
        {

        }

        public override bool IsValid()
        {
            if (!base.IsValid())
            {
                return false;
            }
            return true;
        }

        public override Point GetPoint(int index)
        {
            if (index <= 4)
            {
                return base.GetPoint(index);
            }
            throw new ArgumentOutOfRangeException();
        }
    }
}

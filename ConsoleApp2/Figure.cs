using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleFour
{
    class Figure
    {
        public Figure(List<Point> points)
        {
            this.points.AddRange(points);

            for (int i = 0; i < points.Count; ++i)
            {
                int j = (i + 1) % points.Count;
                this.sides.Add(new Side(points[i], points[j]));
            }
        }

        public virtual bool IsValid()
        {
            if (points.Count < 3)
            {
                return false;
            }
            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    if (points[i].Equals(points[j]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public virtual Point GetPoint(int index)
        {
            return points[index];
        }

        public List<Side> Sides {
            get
            {
                return sides;
            }
        }

        private List<Point> points = new List<Point>();
        private List<Side> sides = new List<Side>();
    }
}

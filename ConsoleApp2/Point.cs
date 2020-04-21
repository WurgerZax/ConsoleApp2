using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFour
{
    class Point : IEquatable<Point>
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public bool Equals(Point point)
        {
            return X == point.X && Y == point.Y;
        }
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }

        private double x;
        private double y;

        public double Y { get => y; set => y = value; }
        public double X { get => x; set => x = value; }
    }
}

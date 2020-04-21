using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFour
{
    class Side : IEquatable<Side>
    {
        public Side(Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;
        }

        public double Length
        {
            get
            {
                return Math.Sqrt(Math.Pow(Point1.X - Point2.X, 2) + Math.Pow(Point1.Y - Point2.Y, 2));
            }
        }

        public double ComputeAngleTo(Side side)
        {
            Side side1;
            Side side2;

            if (this.Point1.Equals(side.Point1)) {
                side1 = this;
                side2 = side;
            } else if (this.Point2.Equals(side.Point2)) {
                side1 = new Side(this.Point2, this.Point1);
                side2 = new Side(side.Point2, side.Point1);
            } else if (this.Point1.Equals(side.Point2)) {
                side1 = this;
                side2 = new Side(side.Point2, side.Point1);
            } else if (this.Point2.Equals(side.Point1)) {
                side1 = new Side(this.Point2, this.Point1);
                side2 = side;
            } else
            {
                throw new Exception("Sides must have one same point");
            }
            Point a1 = new Point(side1.Point2.X - side1.Point1.X, side1.Point2.Y - side1.Point1.Y);
            Point a2 = new Point(side2.Point2.X - side2.Point1.X, side2.Point2.Y - side2.Point1.Y);
            double a1a2 = a1.X * a2.X + a1.Y * a2.Y;
            return (180 / Math.PI) * Math.Acos(a1a2 / (side1.Length * side2.Length));
        }

        public bool Equals(Side side)
        {
            return ((Point1.Equals(side.Point1) && Point2.Equals(side.Point2)) ||
                (Point1.Equals(side.Point2) && Point2.Equals(side.Point1)));
        }

        public override int GetHashCode()
        {
            return Point1.GetHashCode() ^ Point2.GetHashCode();
        }

        private Point point1;
        private Point point2;

        public Point Point1 { get => point1; set => point1 = value; }
        public Point Point2 { get => point2; set => point2 = value; }
    }
}

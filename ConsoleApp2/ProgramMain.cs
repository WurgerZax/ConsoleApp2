using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleFour;

namespace ConsoleApp2
{
    class ProgramMain
    {
        static void Main(string[] args)
        {
            //Side side1 = new Side(new Point(1, 1), new Point(6, 7));
            //Side side2 = new Side(new Point(6, 7), new Point(10, 20));
            //Console.WriteLine($"{side1.ComputeAngleTo(side2)}");
            //Rhombus rhombus = new Rhombus(new Point(1, 1), new Point(3, 4), new Point(6, 7), new Point(10, 20));
            //Rhombus rhombus = new Rhombus(new Point(0, 0), new Point(-3, -12), new Point(0, -24), new Point(3, -12));
            //Rhombus rhombus = new Rhombus(new Point(0, 0), new Point(-3, -12), new Point(0, -25), new Point(3, -12));
            Rhombus rhombus = new Rhombus(new Point(1, 1), new Point(1, 4), new Point(4, 4), new Point(4, 1));
            Console.WriteLine($"{rhombus.IsValid()}");
        }
    }
}

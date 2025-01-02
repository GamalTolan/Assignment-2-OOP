using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_OOP.Data
{
    public struct Point
    {
        public double x, y;

        public Point(double _x, double _y)
        {
            x = _x;
            y = _y;
        }
        public static double Distance(Point P1, Point P2)
        {
            return Math.Sqrt((P2.x - P1.x) * (P2.x- P1.x) + (P2.y - P1.y) * (P2.y - P1.y));
        }

    }
}

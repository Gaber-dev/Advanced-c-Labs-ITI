using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class _3DPoint : IComparable<_3DPoint> , ICloneable
    {
            public int X;
            public int Y;
            public int Z;

            public _3DPoint() : this(0, 0, 0) // Default
            {

            }

            public _3DPoint(int x, int y) : this(x, y, 0)
            {

            }


            public _3DPoint(int x, int y, int z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            public void Display()
            {
                Console.WriteLine($"X = {X} , Y = {Y} , Z = {Z}");
            }



            public static int CalculateDistance(_3DPoint p1, _3DPoint p2) // x , y , z  => Class.MethodName
            {
                return Math.Abs(p1.X - p2.X);
            }

       // Sort function => CompareTo Function => IComparable interface => _3DPoint1.CompareTo(_3DPoint2)

        public int CompareTo(_3DPoint? other)
        {
            if (this.X == other.X) return 0;
            if (this.X > other.X) return 1;

            return -1;
        }

        public override string ToString()
        {
            return $"X = {X} , Y = {Y} , Z = {Z}";
        }

        public object Clone()
        {
            _3DPoint p =  (_3DPoint) this.MemberwiseClone();
            return p;
        }
    }


}


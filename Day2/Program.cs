using Day_6;
using System.Security.Cryptography;

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _3DPoint[] points = new _3DPoint[]
            {
                new _3DPoint(5 , 4 , 6),
                new _3DPoint (7 , 10 , 20),
                new _3DPoint(2 , 1 , 3)
            };

            Array.Sort(points);

            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine(points[i]);
            }

            _3DPoint p1 = new _3DPoint(5, 4, 1);
            _3DPoint p2 = (_3DPoint) p1.Clone();
            Console.WriteLine(p2);
            Console.WriteLine(p1); // Same

            Console.WriteLine("---------------------------------------------");


            Trainee t1 = new Trainee()
            {
                Age = 22
            };
            t1.ShowPayment();


            Trainee t = new Trainee
            {
                Name = "Fatima",
                Age = 26,
                address = new Address { City = "Cairo", Street = "Tahrir", ZipCode = 11511 },
                NID = "98765432109876",
                IntakeNumber = 2023
            };

            Trainee t5 = new Trainee
            {
                Name = "Fathi",
                Age = 25,
                address = new Address { City = "Cairo", Street = "Tahrir", ZipCode = 11511 },
                NID = "98765432109476",
                IntakeNumber = 20247
            };
            if(t.CompareTo(t5) == 0)
            {
                Console.WriteLine("Equals");
            }else if(t.CompareTo(t5) == 1)
            {
                Console.WriteLine(t.ToString());
            }
            else
            {
                Console.WriteLine(t5.ToString());
            }
        }
    }
}

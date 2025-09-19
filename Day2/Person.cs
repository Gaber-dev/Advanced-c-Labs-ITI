using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address address { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Address: {address}";
        }

        public abstract Person Clone();

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class Address
    {
        // City, Street & ZipCode
        public string City { get; set; }
        public string Street { get; set; }

        public int ZipCode { get; set; }

        public override string ToString()
        {
            return $"City: {City}, Street: {Street}, ZipCode: {ZipCode}";
        }
    }
}
using Day2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class Trainee : Person , IPayable , IComparable<Trainee>
    {
        public string NID { get; set; }
        public int IntakeNumber { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}, NID: {NID}, IntakeNumber: {IntakeNumber}";
        }

        public override Person Clone()
        {
            Person c = (Person)this.MemberwiseClone();

            // City , street , zipcode


            c.address = new Address();
            c.address.City = this.address.City;
            c.address.Street = this.address.Street;
            c.address.ZipCode = this.address.ZipCode;

            return c;
        }

        public void ShowPayment()
        {
            Console.WriteLine("I am just Trainee and i am not have a salary..");
        }
        // t1.CompareTo(t2)  based on Age for example
        public int CompareTo(Trainee? other)
        {
            if (this.Age == other.Age) return 0;
            if (this.Age > other.Age) return 1;

            return -1;
        }
    }
}
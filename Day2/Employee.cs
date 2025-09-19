using Day2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class Employee : Person , IPayable
    {
        public string NID { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}, NID: {NID}, Salary: {Salary}";
        }

        public override Person Clone()
        {
            //return new Employee
            //{
            //    Name = this.Name,
            //    Age = this.Age,
            //    address = new Address { City = this.address.City, Street = this.address.Street, ZipCode = this.address.ZipCode },
            //    NID = this.NID,
            //    Salary = this.Salary
            //};

            Person p = (Person)this.MemberwiseClone();

            // City , street , zipcode


            p.address = new Address();
            p.address.City = this.address.City;
            p.address.Street = this.address.Street;
            p.address.ZipCode = this.address.ZipCode;

            return p;


        }

        public void ShowPayment()
        {
            Console.WriteLine($"My salary is {Salary}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Assignment5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a company
            Company realEstateCompany = new Company("JSW", "JEREENA", "98765423");

            // Add employees
            realEstateCompany.AddEmployee(new Employee("JEREENA", " Manager", 5));
            realEstateCompany.AddEmployee(new Employee("JERRI", " Agent", 3));

            // Create estates
            var apartment = new Apartment(85, 1200, "MELPURAM", 3, true, true);
            var house = new House(200, 800, "MARTHANDAM", 150, 50, 2, false);
            var land = new UndevelopedArea(1000, 500, "REMOTE");
            var shop = new Shop(150, 2000, "City ");

            // Add estates to the company
            realEstateCompany.AddEstate(apartment);
            realEstateCompany.AddEstate(house);
            realEstateCompany.AddEstate(land);
            realEstateCompany.AddEstate(shop);

            // Display information
            Console.WriteLine("Company Employees:");
            realEstateCompany.DisplayEmployees();
            Console.WriteLine("\nEstates for Sale:");
            realEstateCompany.DisplayEstates();
            Console.ReadKey();
        }
    }
}

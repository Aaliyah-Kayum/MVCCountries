using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    class CountryView
    {
        Country Country { get; set; }
        public CountryView(Country Country)
        {
            this.Country = Country;
        }

        public void Display()
        {
            Console.WriteLine("Country Display: ");
            Console.WriteLine("Name: " + Country.Name);
            Console.WriteLine("Continent: " + Country.Continent);
            Console.WriteLine("Colors: " + Country.Colors);
        }
    }
}

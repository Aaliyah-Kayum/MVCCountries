using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    class CountryController
    {
        public List<Country> CountryDb { get; set; }
        public CountryController()
        {
            CountryDb.Add(new Country() { Name = "America", Continent = "North America", Colors = { "Red", "White", "Blue" } });
            CountryDb.Add(new Country() { Name = "Japan", Continent = "Asia", Colors = { "Red", "White" } });
            CountryDb.Add(new Country() { Name = "Italy", Continent = "Europe", Colors = { "Green", "Red", "White" } });
            CountryDb.Add(new Country() { Name = "France", Continent = "Europe", Colors = {"Blue", "White", "Red" }});
        }  
        public void CountryAction(Country c)
        {
            CountryListView cd = new CountryListView(CountryDb);

            int index = cd.Display();
            Country c = CountryDb[index];

            CountryAction(c);
        }
        public void WelcomeAction(Country c)
        {
            CountryDb = new List<Country>();
            {
                Console.WriteLine("Hello, Welcome to the Country app. Please select a Country from the following list: ");
                CountryView cv = new CountryView(c);
                cv.Display();
            }
        }
    }
}

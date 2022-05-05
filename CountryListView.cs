using MVCCountries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    class CountryListView
    {
        public List<Country> Countries { get; set;}
        public CountryListView(List<Country> Countries)
        {
            this.Countries = Countries;
        }
        public void Display()
        {
            Console.WriteLine("Here are a list of Countries: ");
            for (int i = 0; i < Countries.Count; i++)
            {
                Country country = Countries[i];
                Console.WriteLine(i+ " : " + country.Name);
            }
            Console.WriteLine("Please select the Country you'd like to learn more about");
            string answer = Console.ReadLine();
            int input = int.Parse(answer);
            Console.WriteLine(input);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Lab
{
    public class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country country)
        {
            DisplayCountry = country;
        }

        public void Display()
        {
            Console.WriteLine("Name: {0}", DisplayCountry.Name);
            Console.WriteLine("Continent: {0}", DisplayCountry.Continent);
            Console.WriteLine("Colors:");
            foreach (var color in DisplayCountry.Colors)
            {
                Console.WriteLine("- {0}", color);
            }
        }
    }

}

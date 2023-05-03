using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Lab
{
    public class CountryController
    {
        public List<Country> CountryDb { get; set; }

        public CountryController(List<Country> countryDb)
        {
            CountryDb = countryDb;
        }

        public void CountryAction(Country c)
        {
            CountryView countryView = new CountryView(c);
            countryView.Display();
        }

        public void WelcomeAction()
        {
            CountryListView countryListView = new CountryListView(CountryDb);
            countryListView.Display();

            Console.Write("Enter a country index to learn more: ");
            int index = int.Parse(Console.ReadLine());

            Country selectedCountry = CountryDb[index - 1];
            CountryAction(selectedCountry);

            Console.Write("Would you like to learn about another country? (y/n): ");
            string response = Console.ReadLine();

            if (response == "y")
            {
                WelcomeAction();
            }
            else
            {
                Console.WriteLine("Goodbye");
                return;
            }
        }
    }
}

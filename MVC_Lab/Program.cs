namespace MVC_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of countries
            List<Country> countries = new List<Country>()
        {
            new Country("USA", "North America", new List<string>() { "Red", "White", "Blue" }),
            new Country("Japan", "Asia", new List<string>() { "Red", "White" }),
            new Country("Brazil", "South America", new List<string>() { "Green", "Yellow", "Blue" })
        };

            // Create a country controller
            CountryController countryController = new CountryController(countries);

            // Call the welcome action to display the list of countries and prompt the user for input
            countryController.WelcomeAction();

           
            
        }
    }
}
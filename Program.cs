class Program
{

    public static void Main()
    {
        Console.WriteLine("Search Methods press any key to start.");
        Console.ReadKey();
        Console.Clear();
        ParameterInput();
    }

    public static string ParameterInput()
    {
        Console.WriteLine("Enter Search type // -DRL DIRECT URL //  // -SCH SEARCH //");

        string? sType = Console.ReadLine();
        string? searchParameter;
        string? searchType = null;


        if (sType == "-DRL")
        {
            Console.Clear();
            Console.WriteLine("-DRL Selected Direct URL Search method");
            searchParameter = Console.ReadLine();
            searchType = searchParameter;
            MethodOutputTest(searchType);
        }
        else if (sType == "-SCH")
        {
            Console.Clear();
            Console.WriteLine("-SCH Selected Search method");
            searchParameter = Console.ReadLine();
            searchType = "https://www.google.co.uk/search?q=" + searchParameter;
            MethodOutputTest(searchType);
        }
        else
        {
            Console.WriteLine("Command unknown");
            Console.Clear();
            ParameterInput();
        }
        return searchType!;

    }
    public static void MethodOutputTest(string? searchType)
    {
        Console.WriteLine("Debug: from MethodOutputTest this should be the correct type and parameter. : " + searchType);
    }
}


////Task 1
//class Program
//{
//    static void Main()
//    {
//        // Declare and initialize variables
//        string userName = "Shittal";
//        int luckyNumber = 10;

//        // Display the message using string interpolation
//        Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");
//    }
//}



//class Circle
//{
//    // Constant variable
//    public const double PI = 3.14;

//    // Method to calculate area
//    public static double CalculateArea(double radius)
//    {
//        return PI * radius * radius;
//    }

//    // Method to calculate perimeter
//    public static double CalculatePerimeter(double radius)
//    {
//        return 2 * PI * radius;
//    }
//}

//class Program
//{
//    static void Main()
//    {


//        double radius = 5;

//        Console.WriteLine($"Circle with radius: {radius}");
//        Console.WriteLine($"Area: {Circle.CalculateArea(radius)}");
//        Console.WriteLine($"Perimeter: {Circle.CalculatePerimeter(radius)}");
//    }
//}

////Task3

//class Program
//{
//    static void Main()
//    {
//        // Declare and initialize variables of various data types
//        byte Byte = 20;
//        short Short = 200;
//        int Int = 1000;
//        long Long = 100000L;
//        float Float = 3.14f;
//        double Double = 99.99;
//        decimal Decimal = 123.456m;
//        char Char = 'A';
//        bool Bool = true;

//        // Type conversions
//        int number = 42;
//        string numberAsString = number.ToString(); // Convert int to string

//        string strValue = "3.14";
//        double stringToDouble = Convert.ToDouble(strValue); // Convert string to double

//        // Print all variables
//        Console.WriteLine("=== Data Types and Type Conversion ===");
//        Console.WriteLine($"byte: {Byte}");
//        Console.WriteLine($"short: {Short}");
//        Console.WriteLine($"int: {Int}");
//        Console.WriteLine($"long: {Long}");
//        Console.WriteLine($"float: {Float}");
//        Console.WriteLine($"double: {Double}");
//        Console.WriteLine($"decimal: {Decimal}");
//        Console.WriteLine($"char: {Char}");
//        Console.WriteLine($"bool: {Bool}");
//        Console.WriteLine();
//        Console.WriteLine($"Converted int to string: \"{numberAsString}\" (Type: {numberAsString.GetType()})");
//        Console.WriteLine($"Converted string \"{strValue}\" to double: {stringToDouble} (Type: {stringToDouble.GetType()})");
//    }
//}


////Task 4

//class Program
//{
//    static void Main()
//    {

//        DateTime birthDate = new DateTime(2002, 05, 10);
//        DateTime currentDate = DateTime.Now;

//        // Calculate age using TimeSpan
//        TimeSpan ageSpan = currentDate - birthDate;

//        // Convert total days to years (approximate)
//        int ageInYears = (int)(ageSpan.TotalDays / 365.25);

//        // Add 10 days to the birthdate
//        DateTime newDate = birthDate.AddDays(10);

//        // Print results
//        Console.WriteLine("=== DateTime and TimeSpan Example ===");
//        Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
//        Console.WriteLine($"Current Date: {currentDate}");
//        Console.WriteLine($"my Age: {ageInYears} years");
//        Console.WriteLine($"my birthdate plus 10 days: {newDate.ToShortDateString()}");
//    }
//}


////Task 5
class Program
{
    static void Main()
    {

        List<string> fruits = new List<string> { "Strawberry", "Apple", "Orange" };
        fruits.Add("Banana");

        // Remove one fruit
        fruits.Remove("Apple");

        // Print all fruits in the list
        Console.WriteLine("=== List of Fruits ===");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Create a Dictionary<int, string> for fruit IDs and names
        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
        {
            { 1, "Strawberry" },
            { 2, "Apple" },
            { 3, "Banana" }
        };

        // Add a new entry
        fruitDictionary.Add(4, "Grapes");

        // Print all key-value pairs
        Console.WriteLine("\n=== Fruit Dictionary ===");
        foreach (KeyValuePair<int, string> entry in fruitDictionary)
        {
            Console.WriteLine($"ID: {entry.Key}, Fruit: {entry.Value}");
        }
    }
}


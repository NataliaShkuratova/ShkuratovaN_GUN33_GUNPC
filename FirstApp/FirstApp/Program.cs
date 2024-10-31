class Program
{
    static void Main(string[] args)
    {
    Console.Title = "CalculatorApp";
    Console.WriteLine("Please enter the first number");
        if (!Int32.TryParse(Console.ReadLine(), out var FirstNumber))
        {
            Console.WriteLine("Error! Not a number!");
            return;
        }

    Console.WriteLine("Please enter the second number");
        if (!Int32.TryParse(Console.ReadLine(), out var SecondNumber))
        {
            Console.WriteLine("Error! Not a number!");
            return;
        }

    Console.WriteLine("Enter a logical operator (& | ^)");
        var userInput = Console.ReadLine();
        if (userInput is { Length: 0 or > 1})
        {
            Console.WriteLine("Error! Wrong sign!");
            return;
        }

        int result;
        switch (userInput?[0])
        {
            case '&':
                result = FirstNumber & SecondNumber;
                break;
            case '|':
                result = FirstNumber | SecondNumber;
                break;
            case '^':
                result = FirstNumber ^ SecondNumber;
                break;
            default:
                Console.WriteLine("Error! Wrong sing!");
                return;
        }
        Console.WriteLine($"Result of {FirstNumber} {userInput[0]} {SecondNumber} = {result}");
        Console.WriteLine($"Binary system (2): Result of {FirstNumber} {userInput[0]} {SecondNumber} = {Convert.ToString(result, 2)}");
        Console.WriteLine($"Decimal system(10): Result of {FirstNumber} {userInput[0]} {SecondNumber} = {result}");
        Console.WriteLine($"Hexadecimal system (16): Result of {FirstNumber} {userInput[0]} {SecondNumber} = {Convert.ToString(result, 16)}");
    }
}
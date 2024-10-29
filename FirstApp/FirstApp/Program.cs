class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("Enter the first number");
        if (!Int32.TryParse(Console.ReadLine(), out var a))
        {
            Console.WriteLine("Not a number!");
            return;
        }

    Console.WriteLine("Enter the second number");
        if (!Int32.TryParse(Console.ReadLine(), out var b))
        {
            Console.WriteLine("Not a number!");
            return;
        }

    Console.WriteLine("Enter the operator &, | or ^");
        var s = Console.ReadLine();
        var boolVar = true;
        if (s.Length == 0 || s.Length > 1 && !boolVar)
        {
            Console.WriteLine("Wrong sign");
            return;
        }

        switch (s[0])
        {
            case '&':
                Console.WriteLine("Your input: {0} & {1}", a, b);
                int r0 = Convert.ToInt32(a & b);
                string r0x2 = Convert.ToString(r0, 2);
                Console.WriteLine("In the binary system, this is: " +r0x2);
                string r0x10 = Convert.ToString(r0, 10);
                Console.WriteLine("In the decimal system, this is: " +r0x10);
                string r0x16 = Convert.ToString(r0, 16);
                Console.WriteLine("In the hexadecimal system, this is: " + r0x16);
                break;
            case '|':
                Console.WriteLine("Your input: {0} | {1}", a, b);
                int r1 = Convert.ToInt32(a | b);
                string r1x2 = Convert.ToString(r1, 2);
                Console.WriteLine("In the binary system, this is: " + r1x2);
                string r1x10 = Convert.ToString(r1, 10);
                Console.WriteLine("In the decimal system, this is: " + r1x10);
                string r1x16 = Convert.ToString(r1, 16);
                Console.WriteLine("In the hexadecimal system, this is: " + r1x16);
                break;
            case '^':
                Console.WriteLine("Your input: {0} ^ {1}", a, b);
                int r2 = Convert.ToInt32(a ^ b);
                string r2x2 = Convert.ToString(r2, 2);
                Console.WriteLine("In the binary system, this is: " + r2x2);
                string r2x10 = Convert.ToString(r2, 10);
                Console.WriteLine("In the decimal system, this is: " + r2x10);
                string r2x16 = Convert.ToString(r2, 16);
                Console.WriteLine("In the hexadecimal system, this is: " + r2x16);
                break;
        }
    }
}
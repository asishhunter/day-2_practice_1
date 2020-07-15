using System;


namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Interface1 Addition = new Calculator();
            int a = Addition.Add(-4, -6);
            Console.WriteLine(a);
            Addition = new AdvancedCalculator();
            a = Addition.Add(-4, -6);
            Console.WriteLine(a);
        }
    }
}

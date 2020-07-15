using System;


namespace Interface
{
    class AdvancedCalculator : Interface1
    {
        public int Add(int number1, int number2)
        {
            if (number1 < 0 || number2 < 0)
                return 0;
            else
                return number1 + number2;
        }

        public bool Compare(int number1, int number2)
        {
            return number1 < number2;
        }

        public int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}

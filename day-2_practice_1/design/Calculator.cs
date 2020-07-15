using System;


namespace Interface
{
    class Calculator : Interface1
    {
        public int Add(int number1, int number2)
        {
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

using System;


namespace ProductManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Refrigerator Ref = new Refrigerator();
            Ref.SetRefrigeratorData(7345, "XL", "LG", 25000, "120 W", "5", "Double Door");
            Ref.Display();
        }
    }
    
}

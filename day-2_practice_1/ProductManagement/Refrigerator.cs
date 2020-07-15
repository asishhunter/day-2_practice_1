using System;


namespace ProductManagement
{
    class Refrigerator : Product
    {
        string powersupply;
        string stars;
        string type;

        internal void SetRefrigeratorData(int productId, string model, string brand, int price,
            string powersupply,string stars,string type)
        {
            base.SetProductData(productId,model,brand,price);
            this.powersupply = powersupply;
            this.stars = stars;
            this.type = type;
        }
        internal override void Display()
        {
            base.Display();
            Console.WriteLine($"Power :{powersupply} Stars :{stars} Type :{type}");
        }
    }
}

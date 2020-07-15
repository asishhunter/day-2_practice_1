using System;


namespace ProductManagement
{
    class Product
    { 
            int productId;

            string model;
            string brand;
            int price;

            protected void SetProductData(int productId, string model, string brand, int price)
            {
                this.productId = productId;
                this.model = model;
                this.brand = brand;
                this.price = price;
            }

            internal virtual void Display()
            {

                Console.WriteLine($"ID : {productId} Brand : {brand} Model : {model} Price : Rs.{price}");
            }
        
    }
}

using System;
using Lista_Objetos_17_12.Classes;

namespace Lista_Objetos_17_12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Product p1 = new Product(1,"Red Dead Redemption 2",399f);
            
            Product p2 = new Product(2,"GTA V",295.50f);
            
            Product p3 = new Product(3,"Bully",170.32f);
            
            Product p4 = new Product(4,"Last of Us 2",270.32f);


            ShoppingCart cart = new ShoppingCart();

            cart.AddProduct(p1);
            cart.AddProduct(p2);
            cart.AddProduct(p3);
            cart.AddProduct(p4);


            cart.ShowProduct();


            Product p5 = new Product(5,"GTA San Andreas",120f);


            cart.AlterItem(1,p5);


            cart.ShowProduct();


        }
    
    }
}

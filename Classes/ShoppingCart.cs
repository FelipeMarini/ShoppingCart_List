using System;
using System.Collections.Generic;

namespace Lista_Objetos_17_12.Classes
{
    public class ShoppingCart
    {
        public float TotalValue {get;set;}


        List<Product> cart = new List<Product>();


        public void AddProduct(Product product) {

            cart.Add(product);

        }


        public void ShowProduct() {

            if (cart != null) {

                foreach (Product item in cart)
                {
                    
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine();
                    Console.WriteLine($"{item.Code}, {item.Name}, {item.Price}");
                    Console.ResetColor();
                
                }

                ShowTotal();

            }
        }


        public void RemoveProduct(Product product) {

            cart.Remove(product);
        
        }


        public void ShowTotal() {

            if (cart != null) {

                TotalValue = 0;

                foreach (Product item in cart)
                {
                    
                    TotalValue += item.Price;

                }

                Console.WriteLine();
                Console.WriteLine($"Total from shopping cart is: ${TotalValue.ToString("F")}");

            } else {
                
                Console.WriteLine();
                Console.WriteLine("Your shopping cart is empty and has no items");

            }
        }


        public void AlterItem(int wanted_code, Product new_product) {

            cart.Find(x => x.Code == wanted_code).Name = new_product.Name;
            
            cart.Find(x => x.Code == wanted_code).Price = new_product.Price;


        }



    }
}
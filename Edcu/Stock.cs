using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edcu
{
    internal class Stock
    {
        public List<Product> products { set; get; }

        public Stock(List<Product> products)
        {
            this.products = products;
        }
         

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void RemoveProduct(Product product) 
        {
            products.Remove(product);
        }

        public void ShowAllProducts()
        {
            foreach(Product product in products)
            {
                
                product.ShowInfo();
            }
        }
        public Product? TakeProduct(int Id, int count) //Забераем любое количевсто продукта со склада, если берем больше чем есть на скаладе то возвращаем null
        {
            Product? product = products.FirstOrDefault(product => product.Id == Id);
            if(product != null)
            {
                if(count > product.Count)
                {
                    Console.WriteLine("Not enough product in stock");
                    return null;
                }
               
                product.Count -= count;

                if (product.Count == 0)
                {
                    products.Remove(product);
                }

                return product;
                
            }
            return null;
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace Edcu
{
    internal class Product
    {

        private static int _currentId = 1;
        public int Id { get; set; }

        public int Count { get; set; } //Количевсто продукта.
        public string Name { get; set; }

        public string Description { get; set; }


        public Product(string name, string description, int count)
        {
            Id += _currentId;
            Name = name;
            Description = description;
            Count = count;

            _currentId++;
        }

        

        public void ShowInfo()
        {
            if (Id != 0 && Name != string.Empty && Description != string.Empty)
            {
                Console.WriteLine($"Product information:\nId:{Id} \nName: {Name} \nDescription: {Description}\nCount: {Count}\n");
            }
        }
    }
}

using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.Json.Nodes;
using Edcu;
using RandomGenerator;







class Program
{





    static void Main(string[] args)
    {
        GenerateString generateString = new GenerateString();
        GenerateNumber generateNumber = new GenerateNumber();
        List<Product> products = new List<Product>
        {
            new Product("Product1", generateString.genString(15),generateNumber.genNumber(10)),
            new Product("Product2", generateString.genString(15),generateNumber.genNumber(10)),
            new Product("Product3", generateString.genString(15),generateNumber.genNumber(10)),
            new Product("Product4", generateString.genString(15),generateNumber.genNumber(10)),
        };

        Stock stock = new Stock(products);

        stock.ShowAllProducts();

    }


}

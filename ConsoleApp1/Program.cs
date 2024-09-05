using ConsoleApp1;

static void Main(string[] args)
{
    List<Product> products = new List<Product>
        {
            new Toy("Teddy Bear", "Cotton"),
            new Meat("Chicken", 1.5),
            new Drink("Cola", 1.0),
            new Electronics("TV", "Samsung")
        };

    foreach (var product in products)
    {
        Console.WriteLine(product.GetInformation());
    }
}
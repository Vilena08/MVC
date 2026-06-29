public class Product
{
    // Это модель — чистые данные без логики.
    // Она ничего не знает ни о View, ни о Controller.
    public int ID { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }

    public Product(int id, string name, int price)
    {
        ID = id;
        Name = name;
        Price = price;
    }
}
using System;

public class ProductView
{
    // === ВЫВОД: методы, которые показывают информацию пользователю ===
    public void DisplayProduct(Product product)
    {
        Console.WriteLine("=== Product Info ===");
        Console.WriteLine($"ID: {product.ID}, Name: {product.Name}, Price: {product.Price}");
        Console.WriteLine();
    }

    public void ShowMenu()
    {
        Console.WriteLine("1. Create new product");
        Console.WriteLine("2. Exit");
        Console.Write("Choose option: ");
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
        Console.WriteLine();
    }

    public void ShowEmptyLine()
    {
        Console.WriteLine();
    }

    // === ВВОД: методы, которые получают данные от пользователя ===
    public int GetProductIdFromUser()
    {
        Console.Write("Enter product ID: ");
        return int.Parse(Console.ReadLine());
    }

    public string GetProductNameFromUser()
    {
        Console.Write("Enter product name: ");
        return Console.ReadLine();
    }

    public int GetProductPriceFromUser()
    {
        Console.Write("Enter product price: ");
        return int.Parse(Console.ReadLine());
    }
}
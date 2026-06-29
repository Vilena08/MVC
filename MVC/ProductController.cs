using System;

public class ProductController
{
    private Product _product;          // Модель (данные)
    private readonly ProductView _view; // Вид (интерфейс)
    private bool _isRunning;            // Флаг для выхода из цикла

    public ProductController(ProductView view)
    {
        _view = view;
        _isRunning = true;
    }

    // Основной цикл приложения — управляет потоком программы.
    public void Run()
    {
        while (_isRunning)
        {
            _view.ShowMenu(); // Показываем меню

            switch (Console.ReadLine()) // Читаем выбор пользователя
            {
                case "1":
                    _view.ShowEmptyLine();
                    CreateNewProduct();   // Запускаем создание продукта
                    break;

                case "2":
                    _isRunning = false;   // Выход из цикла
                    _view.ShowMessage("Exiting...");
                    break;

                default:
                    _view.ShowMessage("Invalid choice. Try again.");
                    break;
            }
        }
    }

    // Бизнес-логика: создание нового продукта
    public void CreateNewProduct()
    {
        // 1. Запрашиваем данные у View
        int id = _view.GetProductIdFromUser();
        string name = _view.GetProductNameFromUser();
        int price = _view.GetProductPriceFromUser();

        Console.WriteLine();

        // 2. Создаём модель (объект Product)
        _product = new Product(id, name, price);

        // 3. Обновляем View — показываем созданный продукт
        _view.DisplayProduct(_product);
    }
}
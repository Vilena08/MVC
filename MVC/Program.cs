using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // 1. Создаём View
        ProductView view = new ProductView();

        // 2. Создаём Controller и передаём ему View
        ProductController controller = new ProductController(view);

        // 3. Запускаем Controller
        controller.Run();

        Console.ReadKey();
    }
}
//MVC разделяет приложение на три компонента: Модель (данные), Представление (интерфейс) и Контроллер (бизнес-логика). В моём коде Product — это Модель, ProductView отвечает за ввод/вывод, а ProductController управляет потоком программы и созданием объектов. Контроллер не знает, как устроен ввод/вывод — он просто вызывает методы View. View ничего не знает о том, как создаются данные — она только отображает их.
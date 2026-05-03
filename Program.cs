using System;
using System.Threading.Tasks;

// Запрос: Отвечай на русском языке.
// ...
// ... Объясни async/await в C#.
// ... Дай рабочий пример console app.
// ... Код должен компилироваться.
// ... Используй async Task Main().
// ... После примера объясни каждую важную строку.

namespace AsyncAwaitExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Начало программы");

            // Вызов асинхронного метода и ожидание его завершения
            await DownloadDataAsync();

            Console.WriteLine("Конец программы");
        }

        // Асинхронный метод, который возвращает Task (пустой тип)
        static async Task DownloadDataAsync()
        {
            Console.WriteLine("Начало загрузки данных");

            // Имитация асинхронной операции с помощью Task.Delay
            await Task.Delay(2000);

            Console.WriteLine("Завершение загрузки данных");
        }
    }
}

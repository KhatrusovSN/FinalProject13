using System.Diagnostics;

namespace Task1
{
    internal class Program
    {
        static string path = "C:\\Users\\Sergey\\Downloads\\Text1.txt";
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch(); // Создание обьекта 
            var stringList = new List<string>(); // Создание списка
            string text = File.ReadAllText(path); // Запись тестового текста в переменную

            stopWatch.Start(); //Старт 
            foreach (string word in text.Split(" ")) // Заполнение списка словами из текста
            {
                stringList.Add(word);
            }
            stopWatch.Stop(); // Остановка таймера
            Console.WriteLine($"Затрачено на добавление текста в List = {stopWatch.Elapsed.TotalMilliseconds} ms");

            stopWatch.Reset(); // Обуление таймера

            var stringLinkedList = new LinkedList<string>(); // Создание связаного списка

            stopWatch.Start();
            foreach (string word in text.Split(" "))
            {
                stringLinkedList.AddLast(word);
            }
            stopWatch.Stop();
            Console.WriteLine($"Затрачено на добавление текста в LinkedList = {stopWatch.Elapsed.TotalMilliseconds} ms");
        }
    }
}
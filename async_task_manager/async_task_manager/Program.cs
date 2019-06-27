using System;

namespace async_task_manager {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Запуск задачи в текущем потоке:\n");
            var syncronousTask = new AsyncTask();
            double discriminant = syncronousTask.GetDiskriminant();
            Console.WriteLine($"Дискриминант: {discriminant}\n");

            while (true) {
                Console.WriteLine("Введите число потоков:\n");
                int threadsAmount=Int32.Parse(Console.ReadLine());
                Console.WriteLine($"Запуск задач в {threadsAmount} потоках:\n");
                var asyncTaskManager = new AsyncTaskManager(threadsAmount);

            }
        }
    }
}

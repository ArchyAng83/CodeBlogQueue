using CodeBlogQueue.Model;
using System;


namespace CodeBlogQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var easyQueue = new EasyQueue<int>();
            easyQueue.Enqueue(1);
            easyQueue.Enqueue(2);
            easyQueue.Enqueue(3);
            easyQueue.Enqueue(4);
            easyQueue.Enqueue(5);

            Console.WriteLine(easyQueue.Dequeue());
            Console.WriteLine(easyQueue.Peek());
            Console.WriteLine(easyQueue.Dequeue());

            Console.ReadLine();
        }
    }
}

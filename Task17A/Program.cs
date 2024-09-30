using System;

namespace Task17A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedQueue queue = new MyLinkedQueue();

            Entry e1 = new Entry("Anton");
            Entry e2 = new Entry("Berta");
            Entry e3 = new Entry("Caesar");
            Entry e4 = new Entry("Dagmar");
            Entry e5 = new Entry("Emil");

            queue.Enqueue(e1);
            queue.Enqueue(e2);
            queue.Enqueue(e3);
            queue.Enqueue(e4);
            queue.Enqueue(e5);

            while (!queue.IsEmpty())
            {
                queue.Print();
                queue.Dequeue();
            }

            Console.ReadLine();
        }
    }
}

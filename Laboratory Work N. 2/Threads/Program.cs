using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task6 = Task.Factory.StartNew(() => writeNode(6));
            Task.WaitAll(task6);
            Task task5 = Task.Factory.StartNew(() => writeNode(5));
            Task.WaitAll(task5, task6);
            Task task4 = Task.Factory.StartNew(() => writeNode(4));
            Task.WaitAll(task4);
            Task task3 = Task.Factory.StartNew(() => writeNode(3));
            Task.WaitAll(task3, task4);
            Task task2 = Task.Factory.StartNew(() => writeNode(2));
            Task.WaitAll(task2, task3);
            Task task1 = Task.Factory.StartNew(() => writeNode(1));
            Task.WaitAll(task1);
        }

        static void writeNode(object nodeCode)
        {
            Console.WriteLine("Thread" + (int)nodeCode);
            Thread.Sleep(1500);
        }
    }
}

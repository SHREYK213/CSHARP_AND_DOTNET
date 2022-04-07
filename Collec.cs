// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace Colection
{
    class Collec
    {
        static void Main(string[] args)
        {
            var names = new List <string>();
            names.Add("heyo");
            names.Add("how");
            names.Add("are you");
            //names[names.Count - 1] = "lol";

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine(queue.Dequeue());
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());

            var people = new Dictionary<string, int>();
            people.Add("shrey", 22);
            people.Add("shreyas", 23);

            Console.WriteLine(people["shrey"]);
        }
    }
}


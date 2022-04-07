// See https://aka.ms/new-console-template for more information
using System;
namespace Crucialshortcuts
{
    class Shortcuts
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO WORLD");
            Console.WriteLine("!");

            Foo();
            Foo("shrey");
            Person.CelebrateBirthday();
        }

        private static void Foo(string v)
        {
            throw new NotImplementedException();
        }

        private static void Foo()
        {
            throw new NotImplementedException();
        }
    }
}
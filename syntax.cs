// See https://aka.ms/new-console-template for more information
using System;
namespace SyntaxAndStructure
{
    class syntax
    {
        static void Main(string[] args)
        {
           Foo("from runtime");
           Foo("from compiletime");
        }

        static void Foo(string name)
        {
            Console.WriteLine("in foo...");
            Console.WriteLine(name);
        }

    }
}
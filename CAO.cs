using System;
namespace ClassesAndObjects
{
    class COA
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Zoro");
            Person person2 = new Person("luffy");

            person1.age = 28;
            person1.age = 20;

            Console.WriteLine(person1.name);
            Console.WriteLine(person1.age);
        }
    }
}

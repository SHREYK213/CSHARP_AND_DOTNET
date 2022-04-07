using System;
namespace Properties
{
    class Propert
    {
        static void Main(string[] args)
        {
            Human human = new Human(10);

            // Set
            //human.Age = -10;
            //human.Age = 5;

            // Get
            Console.WriteLine(human.Age);
        }
    }
}

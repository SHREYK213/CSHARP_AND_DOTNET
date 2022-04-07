using System;
namespace Methods
{
    class Methods
    {
        static void Main(string[] args)
        {
            var personInfo = GetPersonInfo();
            Console.WriteLine(personInfo.name);
            Console.WriteLine(personInfo.age);

        }
        static (string name, int age) GetPersonInfo()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("enter your age");
            int age =int.Parse(Console.ReadLine());
            
            return (name, age);
        }
    }
}

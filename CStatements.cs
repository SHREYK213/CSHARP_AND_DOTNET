using System;
namespace ConditionalStatements
{
    class CStatements
    {
        static void Main(string[] args)
        {
            bool isYes = true;
            int age = 20;
            if (isYes && age > 10)
                Console.WriteLine("Yes");
            else if (!isYes)
                Console.WriteLine("hmmm");
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("maybe");
            }
            switch (age)
            {
                case 10: Console.WriteLine("Ten"); break;
                case 20: Console.WriteLine("Twenty"); break;
                default:
                    Console.WriteLine("Anything else"); break;
            }
                
        }
    }
}
using System;
namespace Arrays
{
    class Arr
    {
        static void Main(string[] args)
        {
            string[] names = new string[3];
            names[0] = "Monkey";
            names[1] = "D";
            names[2] = "Luffy";

            //printFirst(names);         
            //printLast(names);

            Array.Reverse(names);

            for (int i = 0; i < names.Length; i++)
            {
                string c = names[i];
                Console.WriteLine($"{i+1} {c}");
            }
            

        }
        static void printFirst(string[] values)
        {
            Console.WriteLine(values[0]);
        }        

        static void printLast(string[] values)
        {
            Console.WriteLine(values[values.Length-1]);
        }


    }
}
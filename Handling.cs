using System;
namespace ExceptionHandling
{
    class Handling
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine(Divide(10,0));
            }
            
            //catch (ArgumentException)
            //{
            //    Console.WriteLine("Invalid argument..");
            //}

            catch  //(Exception)
            {
                Console.WriteLine("Oops,something went wrong");
            }
        }

        static int Divide(int a, int b)
        {
            //throw new Exception();
            if (b==0)
            {
                throw new ArgumentException("Argument must not be zero", nameof(b));
            }
            //try
            //{
                return a / b;
            //}
            //catch
            //{
            //    return -1;
            //}
        }
    }
}

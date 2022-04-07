using System;
using System.Text;

namespace Types
{
    class Type
    {
        static void Main(string[] args)
        {
            //House house = new House(10, "Blue");
            //DoStuffTOHouse(house);
            //Console.WriteLine(house.NumberOfWindows);
            //Console.WriteLine(house.Color);

            //House house =new House(1,"Yellow");
            //house = null;
            //Console.WriteLine(house);

            //int? i =null;

            //StringBuilder s = new StringBuilder("test");
            //for (int i = 0; i < 100; i++)
            //{
            //    s.Append("!");
            //}
            //Console.WriteLine(s);
           
        }

        static void DoStuffTOHouse(House house)
        {
            house.NumberOfWindows--;
            house.Color="Red";
        }
    }
}

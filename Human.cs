using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Human
    {
        //private int age;

        //public int Age
        //{
        //    get { return age; }
        //    set 
        //    {
        //        if(value>0)
        //            age = value;
        //        else 
        //            age = 0;
        //    }
        //}

        public Human(int age)
        {
           // Age = age;
        }

        public int Age { get; } = 30;

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace VogtFactory2
{
    class Dog : Pet
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof woof");
        }
    }
}

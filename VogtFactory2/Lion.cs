using System;
using System.Collections.Generic;
using System.Text;

namespace VogtFactory2
{
    class Lion : Pet
    {
        public override void MakeSound()
        {
            Console.WriteLine("Roar roar");
        }
    }
}

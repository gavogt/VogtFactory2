using System;
using System.Collections.Generic;
using System.Text;

namespace VogtFactory2
{
    class Parakeet : Pet
    {
        public override void MakeSound()
        {
            Console.WriteLine("Tweet tweet");
        }
    }
}

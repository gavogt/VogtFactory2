using System;
using System.Collections.Generic;
using System.Text;

namespace VogtFactory2
{
    abstract class Pet
    {
        string Name;
        string Sound;

        public abstract void MakeSound();
    }
}

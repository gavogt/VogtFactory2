using System;
using System.Collections.Generic;
using System.Text;

namespace VogtFactory2
{
    class PetFactory
    {
        public void GetPet(int acres)
        {
            if (acres <= 1)
            {
                Pet pet = new Parakeet();
                pet.MakeSound();
            }
            if (acres <= 4 && acres > 1)
            {
                Pet pet = new Dog();
                pet.MakeSound();
            }
            if(acres <= 9 && acres > 4)
            {
                Pet pet = new Lion();
                pet.MakeSound();
            }
        }
    }
}

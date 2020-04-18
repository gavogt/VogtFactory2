using System;
using System.Collections.Generic;
using System.Text;

namespace VogtFactory2
{
    class Test
    {
        public static void Run()
        {
            int acres;

            Console.WriteLine("How many acres? 1-9");
            acres = Convert.ToInt32(Console.ReadLine());

            PetFactory petFactory = new PetFactory();
            petFactory.GetPet(acres);
        }


    }
}

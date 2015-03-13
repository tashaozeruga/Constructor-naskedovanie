using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_nasledovanie
{
    class Donbas : Fridge 
    {
        bool locked;

        public Donbas(int temp, int volume, bool locked) : base (temp, volume)
        {
            Console.WriteLine("This is Donbas constructor");
            this.locked = locked;
        }

        public void Handle()
        {

            locked = !locked;

            Console.WriteLine(locked ? "The fridge is locked" : "The Fridge is unlocked");
            /*
            if (locked)
            {
                locked = false;
                Console.WriteLine("The Fridge is unlocked");
            }
            else
            {
                locked = true;
                Console.WriteLine("The fridge is locked");
            }
            */
        }

    }
}

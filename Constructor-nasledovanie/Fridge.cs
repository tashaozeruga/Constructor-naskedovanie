using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_nasledovanie
{
    class Fridge
    {
        int temp;

        public int Temp
        {
            get { return temp; }
            set { temp = value; }
        }
        int volume;

        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        public Fridge(int temp, int volume)
        {
            Console.WriteLine("This is Fridge constructor");
            this.temp = temp;
            this.volume = volume;
        }
        
        public void defrost()
        {
            Console.WriteLine("The fridge is defrosted");
            temp = 0;
        }


    }
}

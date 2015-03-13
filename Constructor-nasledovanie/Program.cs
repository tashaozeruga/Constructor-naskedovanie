using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_nasledovanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Donbas d1 = new Donbas(-10, 30, true);

            Console.WriteLine(d1.Temp); 

            d1.defrost();
            Console.WriteLine(d1.Temp);

            d1.Handle();
            d1.Handle();
            d1.Handle();
            d1.Handle();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJER_ANIMAL
{
    internal class Gato : Animal
    {        
        public override void HacerSonido()
        {       
            Console.WriteLine("Miau miau.");
        }
    }
}

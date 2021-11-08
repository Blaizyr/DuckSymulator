using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSymulator
{
    class RocketDuck : Duck
    {
        
        public RocketDuck()
        {
            IFlying = new RocketPropulsion();

        }

        public override void act()
        {
           
        }

        public override void DuckPrint()
        {
            Console.WriteLine("Rakietowa Kaczka melduje się na rozkaz!");
            
        }

    }
}

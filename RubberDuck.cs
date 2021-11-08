using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSymulator
{
    class RubberDuck : Duck
    {
        
        public override void act()
        {
            void swim(){
                NumOfSwims++;
                Console.WriteLine("Gumowa kaczka podpłynęła do Ciebie!");
            }
            swim();
        }

        public RubberDuck()
        {
            
        }

        public RubberDuck(string name)
        {
            this.name = name;
            IQuack = new SimpleQuack();
        }

        public override void DuckPrint()
        {
            Console.WriteLine("Kaczka z gumy here!");
            
        }
        // public RubberDuck();

    }

}

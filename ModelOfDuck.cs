using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSymulator
{
    class ModelOfDuck : Duck
    {
        public override void act()
        {
            void DoNotAct() { Console.WriteLine("Nic nie robi"); }
            DoNotAct();
        }

        public ModelOfDuck()
        {
            IFlying = new DoNotFly();
            IQuack = new SimpleQuack();
        }

        public override void DuckPrint()
        {
            Console.WriteLine("JESTEM KACZYM MODELEM ;]");
            throw new NotImplementedException();
        }
    }
}

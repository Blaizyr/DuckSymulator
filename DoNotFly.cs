using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSymulator
{
    class DoNotFly : IFlying
    {
        public void Fly()
        {
            void DoNotFly() { System.Console.WriteLine("Nie latam!"); }
            DoNotFly();
        }
    }
}

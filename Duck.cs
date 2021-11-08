using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSymulator
{
    abstract class Duck
    {
        protected IFlying IFlying;
        protected IQuack IQuack;
        

        protected string name;
        private static int numOfSwims;
        public static int NumOfSwims
        {
            get { return numOfSwims; }
            set { numOfSwims += value; }
        }

        /*
         * 
         * 
         * Set behavior:
         * 
         */

        public void SetIFly(IFlying fi)
        {
            IFlying = fi;
        }
        public void SetIQuack(IQuack qi)
        {
            IQuack = qi;
        }

        public abstract void act();

        /*
         * 
         * Activate behavior:
         * 
         * 
         */
         
        public void DoFlight()
        {
            IFlying.Fly();
        }
        public void DoQuack()
        {
            IQuack.Quack();
        }

        /*
         * Present Duck:
         */

        public abstract void DuckPrint();
    }
}

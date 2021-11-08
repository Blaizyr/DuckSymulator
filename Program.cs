using System;

namespace DuckSymulator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*
             * do not push Animal.class
             * 
            Animals Lisek = new Animals("Lis", "Chodzi lisek koło drogi");
            Lisek.MakeSound();

            Console.WriteLine("Mamy {0} zwierząt", Animals.NumberOfAnimals);
            */

            Duck GumowaKaczka1 = new RubberDuck("Gumowa Kaczucha");
            GumowaKaczka1.act();
            GumowaKaczka1.DoQuack();

            Console.WriteLine("Kaczki pływały {0} raz(y).", Duck.NumOfSwims);
            Console.WriteLine();

            Duck KaczkaRakietowa1 = new RocketDuck();
            KaczkaRakietowa1.DoFlight();

            Console.WriteLine();
            Console.WriteLine("Wyświetlamy opis typu obu kaczek:");

            GumowaKaczka1.DuckPrint();
            KaczkaRakietowa1.DuckPrint();

            Console.Write("\n"+"Teraz sprawdzamy dynamiczną zmianę kaczego behawioru :) \n");

            Duck KaczyModel1 = new ModelOfDuck();
            KaczyModel1.DoFlight();
            KaczyModel1.SetIFly(new RocketPropulsion()); ;
            KaczyModel1.DoFlight();
        }
    }
}

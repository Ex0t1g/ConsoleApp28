using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Program
    {
    }

    namespace AbstractFactoryPattern
    {
        
        abstract class AbstractBottle
        {
            public abstract void Interact(AbstractWater water);
        }

        
        abstract class AbstractWater { }

        
        class CocaColaBottle : AbstractBottle
        {
            public override void Interact(AbstractWater water)
            {

            }
        }

        class PepsiBottle : AbstractBottle
        {
            public override void Interact(AbstractWater water)
            {

            }
        }


        class CocaColaWater : AbstractWater { }


        class PepsiWater : AbstractWater { }


        abstract class AbstractFactory
        {
            public abstract AbstractBottle CreateBottle();
            public abstract AbstractWater CreateWater();
        }


        class CocaColaFactory : AbstractFactory
        {
            public override AbstractBottle CreateBottle()
            {
                return new CocaColaBottle();
            }

            public override AbstractWater CreateWater()
            {
                return new CocaColaWater();
            }
        }


        class PepsiFactory : AbstractFactory
        {
            public override AbstractBottle CreateBottle()
            {
                return new PepsiBottle();
            }

            public override AbstractWater CreateWater()
            {
                return new PepsiWater();
            }
        }


        class Client
        {
            private AbstractBottle _bottle;
            private AbstractWater _water;

            public Client(AbstractFactory factory)
            {
                _bottle = factory.CreateBottle();
                _water = factory.CreateWater();
            }

            public void Run()
            {
                _bottle.Interact(_water);
            }
        }

        class Program2
        {
            static void Main(string[] args)
            {

                AbstractFactory factory1 = new CocaColaFactory();
                Client client1 = new Client(factory1);
                client1.Run();


                AbstractFactory factory2 = new PepsiFactory();
                Client client2 = new Client(factory2);
                client2.Run();

                Console.ReadKey();
            }
        }
    }
}

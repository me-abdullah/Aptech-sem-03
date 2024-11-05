using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    public abstract class Vehicle
    {
       // public abstract void Startengine();
       // public abstract void Stopengine();
        public abstract void StartEngine();
        public abstract void StopEngine();
    }

    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Car engine stopped");
        }
    }

    public class Motorcycle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Motorcycle engine started");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Motorcycle engine stopped");
        }
    }


    class Program
    {
        static void Main()
        {
            Vehicle myCar = new Car();
            myCar.StartEngine();
            myCar.StopEngine();

            Vehicle myBike = new Motorcycle();
            myBike.StartEngine();
            myBike.StopEngine();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    class Vehicle
    {
        double topSpeed;
       private int engineSize;
       
        string colour;
        double weight;
        public void VehicleSound()
        {
            Console.WriteLine("Baaaaaaang");
        }

        void setEngineSize(int value)
        {
            engineSize = value;
        }

        int getEngineSize(int value)
        {
            return engineSize;
        }
    }
     class Car: Vehicle
    {
        bool IsConvertible;
        
            
        

        public void VehicleSound()
        {
            Console.WriteLine("Vroooom");
        }
    }
    class MotorBike : Vehicle
    {

        public void VehicleSound()
        {
            Console.WriteLine("Broooom");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            MotorBike MB = new MotorBike();
            Vehicle veh = new Vehicle();


            veh.VehicleSound();
            car.VehicleSound();
            MB.VehicleSound();
            
            Console.ReadLine();
        }
    }
}

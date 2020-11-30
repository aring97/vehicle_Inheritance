using System;
namespace vehicle{
    public class Cessna:Vehicle
    {
        public double FuelCapacity{get; set;}
        public void RefuelTank()
        {
            
        }
        public override void Drive()
        {
            System.Console.WriteLine("Vrrrrr");
        }
        public override void Turn(string direction)
        {
            System.Console.WriteLine($"The cessna banked {direction}");
        }
        public override void Stop()
        {
            System.Console.WriteLine("The cessna bounces before rolling to a stop");
        }
    }
}
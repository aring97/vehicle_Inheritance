using System;
namespace vehicle{
    public class Cessna:Vehicle, IGasVehicle
    {
        public int CurrentTankPercentage{get; set;}= 50;
        public void RefuelTank()
        {
            CurrentTankPercentage=100;
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
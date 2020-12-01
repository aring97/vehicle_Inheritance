using System;
namespace vehicle{
    public class Zero:Vehicle, IElectricVehicle
    {
        public int CurrentChargePercentage{get; set;}=45;
        public void ChargeBattery()
        {
            CurrentChargePercentage=100;
        }
        public override void Drive()
        {
            System.Console.WriteLine("Yeow");
        }
        public override void Turn(string direction)
        {
            System.Console.WriteLine($"The Zero turns {direction}");
        }
        public override void Stop(){
            System.Console.WriteLine("The zero quickly stopped");
        }
    }
}
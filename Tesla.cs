using System;
namespace vehicle{
    public class Tesla:Vehicle, IElectricVehicle{
        public int CurrentChargePercentage{get; set;}=60;
        public void ChargeBattery(){
            CurrentChargePercentage=100;
        }
        public override void Drive()
        {
            System.Console.WriteLine("zoom");
        }
        public override void Turn(string direction)
        {
            System.Console.WriteLine($"The tesla turned {direction}");
        }
        public override void Stop()
        {
            System.Console.WriteLine("The Tesla rolles to a stop");
        }
    }
}
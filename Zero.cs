using System;
namespace vehicle{
    public class Zero:Vehicle
    {
        public double BatteryKWh{get; set;}
        public void ChargeBattery()
        {
            
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
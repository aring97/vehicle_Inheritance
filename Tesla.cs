using System;
namespace vehicle{
    public class Tesla:Vehicle{
        public double BatteryKWh{get; set;}
        public void ChargeBattery(){
            
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
using System;
namespace vehicle{
    public class Ram:Vehicle{
    public double FuelCapacity {get; set;}
    public void RefuelTank(){}
    public override void Drive(){
        System.Console.WriteLine("rumble");
    }
    public override void Turn(string direction){
        System.Console.WriteLine($"The ram tured {direction}");
    }
        public override void Stop()
        {
            System.Console.WriteLine("The ram slowly rolled to a stop.");
        }
    }
}
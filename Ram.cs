using System;
namespace vehicle{
    public class Ram:Vehicle, IGasVehicle{
    public int CurrentTankPercentage {get; set;}=70;
    public void RefuelTank(){
        CurrentTankPercentage=100;
    }
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
using System;
namespace vehicle{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }
        public virtual void Drive(){
            System.Console.WriteLine("Vroom");
        }
        public virtual void Turn(string direction){
            System.Console.WriteLine($"The vehicle turned {direction}");
        }
        public virtual void Stop(){
            System.Console.WriteLine("The vehicle rolled to a stop");
        }
    }
}
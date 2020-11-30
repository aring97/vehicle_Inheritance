using System;

namespace vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Cessna myCessna=new Cessna();
            myCessna.MainColor="white";
            myCessna.MaximumOccupancy="5";
            myCessna.Drive();
            myCessna.Turn("right");
            myCessna.Stop();
            Ram myRam=new Ram();
            myRam.MainColor="red";
            myRam.MaximumOccupancy="2";
            myRam.Drive();
            myRam.Turn("left");
            myRam.Stop();
            Tesla myTesla=new Tesla();
            myTesla.MainColor="blue";
            myTesla.MaximumOccupancy="4";
            myTesla.Drive();
            myTesla.Turn("right");
            myTesla.Stop();
            Zero myZero=new Zero();
            myZero.MainColor="black";
            myZero.MaximumOccupancy="1";
            myZero.Drive();
            myZero.Turn("left");
            myZero.Stop();
        }
    }
}

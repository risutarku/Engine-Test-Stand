using System;
using System.Collections.Generic;

namespace TestsForEngine
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int [] momentTorque = new int [] { 20, 75, 100, 105, 75, 0 };
            int[] speed = new int[]           { 0, 75, 150, 200, 250, 300 };
            int inertialMoment = 10;
            int tempretureOverHeat = 110;
            double Hm = 0.01;
            double Hv = 0.0001;
            double C = 0.1;

            Engine engine = new Engine(inertialMoment, momentTorque, speed, tempretureOverHeat, Hm, Hv, C);

            TestStand test= new TestStand();    
            test.Simulation(engine);

            TestStand testOverheat = new TestStandEngineOverheat();
            testOverheat.Simulation(engine);

            TestStand testMaxPower = new TestStandEngineMaxPower();
            testMaxPower.Simulation(engine);
        }
    }
}

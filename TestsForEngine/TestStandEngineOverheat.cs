using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsForEngine
{
    internal class TestStandEngineOverheat : TestStand
    {
        public override void Simulation(Engine engine)
        {
            double outsideTemperature = TestStandEngineOverheatService.GetOutsideTemperature();

            int time = 0;
            double speed = engine.RotationSpeed[0];
            int torque;
            double heatTemperature;
            double coldTemperature;
            double engineTemperature = outsideTemperature;
            double acceleeration;

            while (speed < engine.RotationSpeed[engine.RotationSpeed.Length - 1])
            {
                time++;
                torque = TestStandService.GetTorqueBySpeed(engine.TorqueMoment, engine.RotationSpeed, speed);
                acceleeration = TestStandService.GetAcceleration(torque, engine.InertialMoment);
                speed += acceleeration;

                heatTemperature = TestStandEngineOverheatService.GetHeatTemperature(torque, speed, engine.OverheatXTorqueCoefficient, engine.OverheatXRotationSpeedCoefficient);
                coldTemperature = TestStandEngineOverheatService.GetColdTemperature(engine.C, outsideTemperature, engineTemperature);
                engineTemperature += TestStandEngineOverheatService.GetHeatingSpeed(heatTemperature, coldTemperature);

                if (engineTemperature > engine.OverheatTemperature)
                {
                    Console.WriteLine($"Двигатель перегрелся! Время работы: {time}с");
                    break;
                }
            }

            if (speed >= engine.RotationSpeed[engine.RotationSpeed.Length - 1])
                Console.WriteLine("Двигатель завершил свою работу");
        }
    }
}

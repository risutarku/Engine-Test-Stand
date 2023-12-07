using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsForEngine
{
    internal class TestStandEngineMaxPower : TestStand
    {
        public override void Simulation(Engine engine)
        {
            double maxPower = 0;
            double currentPower;
            double maxPowerSpeed = 0;
            int time = 0;
            double speed = engine.RotationSpeed[0];
            int torque;
            double acceleration;

            while (speed < engine.RotationSpeed[engine.RotationSpeed.Length - 1])
            {
                time++;
                torque = TestStandService.GetTorqueBySpeed(engine.TorqueMoment, engine.RotationSpeed, speed);
                acceleration = TestStandService.GetAcceleration(torque, engine.InertialMoment);
                speed += acceleration;
                currentPower = TestStandEngineMaxPowerServise.GetPower(torque, speed);
                if (currentPower > maxPower)
                {
                    maxPower = currentPower;
                    maxPowerSpeed = speed;
                }
                Console.WriteLine($"Скорость: {speed}р/сек Время {time}с");
            }

            Console.WriteLine("Двигатель завершил свою работу");
            Console.WriteLine($"Максимальная мощность: {maxPower}кВт, при скорости {maxPowerSpeed}рад/сек");
        }
    }
}


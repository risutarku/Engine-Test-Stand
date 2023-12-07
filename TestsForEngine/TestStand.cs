using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsForEngine
{
    internal class TestStand
    {
        public virtual void Simulation(Engine engine)
        {
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
                Console.WriteLine($"Скорость: {speed} Время {time}с");
            }

            Console.WriteLine("Двигатель завершил свою работу");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsForEngine
{
    public class TestStandService
    {
        public static double GetAcceleration(double torque, double inertialMoment)
        {
            if (inertialMoment > 0)
            {
                return torque / inertialMoment;
            }
            else
            {
                Console.WriteLine("Неверные входные данные");
                return 0;
            }
        }
        public static int GetTorqueBySpeed(int[] torqueMoment, int[] rotationSpeed, double speed)
        {
            if (speed < rotationSpeed[0])
                return 0;

            if (speed > rotationSpeed[rotationSpeed.Length - 1])
                return 0;

            int torque = torqueMoment[0];
            for (int i = 0; i < torqueMoment.Length - 1; i++)
            {
                if (speed > rotationSpeed[i])
                    torque = torqueMoment[i];
            }
            return torque;
        }
    }
}

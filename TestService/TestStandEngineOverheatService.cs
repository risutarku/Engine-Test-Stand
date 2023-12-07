using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsForEngine
{
    public class TestStandEngineOverheatService
    {
        public static double GetOutsideTemperature()
        {
            while (true)
            {
                Console.WriteLine("Введите температуру окружающей среды");
                string input = Console.ReadLine();
                if (double.TryParse(input, out double outsideTemperature))
                {
                    if (outsideTemperature >= -273)
                    {
                        return outsideTemperature;
                    }
                    else
                    {
                        Console.WriteLine("Неверный ввод, попробуйте снова\n");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод, попробуйте снова\n");
                }
            }
        }
        public static double GetHeatTemperature(double torque, double speed, double overheatXTorqueCoefficient, double overheatXRotationSpeedCoefficient)
        {
            return torque * overheatXTorqueCoefficient + Math.Pow(speed, 2) * overheatXRotationSpeedCoefficient;
        }
        public static double GetColdTemperature(double C, double outsideTemperature, double engineTemperature)
        {
            return C * (outsideTemperature - engineTemperature);
        }
        public static double GetHeatingSpeed(double overheatSpeed, double coldSpeed)
        {
            return overheatSpeed - coldSpeed;
        }
    }
}

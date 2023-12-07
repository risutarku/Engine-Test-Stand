using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsForEngine
{
    internal class Engine
    {
        public int InertialMoment { get; set; }
        public int[] TorqueMoment { get; set; }
        public int[] RotationSpeed { get; set; }
        public double OverheatTemperature { get; set; }
        public double OverheatXTorqueCoefficient { get; set; }
        public double OverheatXRotationSpeedCoefficient { get; set; }
        public double C { get; set; }

        public Engine(int inertialMoment, int[] torqueMoment, int[] rotationSpeed, double temperatureOverheat,
                double overheatXTorqueCoefficient, double overheatXRotationSpeedCoefficient, double C)
        {
            InertialMoment= inertialMoment;
            TorqueMoment= torqueMoment;
            RotationSpeed= rotationSpeed;
            OverheatTemperature = temperatureOverheat;
            OverheatXTorqueCoefficient = overheatXTorqueCoefficient;
            OverheatXRotationSpeedCoefficient = overheatXRotationSpeedCoefficient;
            this.C = C;
        }

    }
}

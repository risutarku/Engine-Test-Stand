using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsForEngine
{
    public class TestStandEngineMaxPowerServise
    {
        public static double GetPower(double torque, double speed)
        {
            return (torque * speed) / 1000;
        }
    }
}

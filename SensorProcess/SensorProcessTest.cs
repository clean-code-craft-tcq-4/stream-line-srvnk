using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace SensorProcess
{
    public class SensorProcessTest
    {
        public void TestTemperatureValues()
        {
            SensorProcessMethods sensorMethod = new SensorProcessMethods();
            List<float> sensorValues = sensorMethod.GenerateTemperatureData(1, 100);
            Assert.IsTrue(sensorValues.All(x => x <= 100 && x > 0));
        }

        public void TestChargeRateValues()
        {
            SensorProcessMethods sensorMethod = new SensorProcessMethods();
            List<float> values = sensorMethod.GenerateChargeRateData(1, 50);
            Assert.IsTrue(values.All(x => x <= 50 && x > 0));
        }
    }
}

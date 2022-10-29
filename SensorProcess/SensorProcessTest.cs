using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SensorProcess
{
    public class SensorProcessTest
    {
        public void TestTemperatureValues()
        {
            SensorProcessMethods sensorMethod = new SensorProcessMethods();
            List<float> sensorValues = sensorMethod.GenerateTemperatureData(1, 100);
            foreach(float sensor in sensorValues)
            {
                Assert.True(sensor <= 100 && sensor > 0);
            }
        }

        public void TestChargeRateValues()
        {
            SensorProcessMethods sensorMethod = new SensorProcessMethods();
            List<float> sensorValues = sensorMethod.GenerateChargeRateData(1, 50);
            foreach (float sensor in sensorValues)
            {
                Assert.True(sensor <= 100 && sensor > 0);
            }
        }
    }
}

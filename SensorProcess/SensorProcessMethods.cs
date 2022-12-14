using System;
using System.Collections.Generic;

namespace SensorProcess
{
    public class SensorProcessMethods
    {
        public List<float> GenerateTemperatureData(float max, float min)
        {
            Random randData = new Random();
            List<float> temperatureData = new List<float>();

            for (int i = 0; i < 50; i++)
            {
                temperatureData.Add((float)(randData.NextDouble()*(max - min)) + min);
            }
            return temperatureData;
        }

        public List<float> GenerateChargeRateData(float max, float min)
        {
            Random randData = new Random();
            List<float> chargeRateData = new List<float>();
            for (int i = 0; i < 50; i++)
            {
                chargeRateData.Add((float)(randData.NextDouble() * (max - min)) + min);
            }
            return chargeRateData;
        }
        public void PrintParameterValues(List<BMSParameterData> bmsParameterData)
        {
            Console.WriteLine("Temperature (Sensor1) Data");

            foreach (BMSParameterData bmsParameter in bmsParameterData)
            {
                Console.WriteLine(bmsParameter.Temperature);
            }

            Console.WriteLine("State Of Charge (SOC) (Sensor2) Data");

            foreach (BMSParameterData bmsParameter in bmsParameterData)
            {
                Console.WriteLine(bmsParameter.ChargeRate);
            }
        }
    }
}

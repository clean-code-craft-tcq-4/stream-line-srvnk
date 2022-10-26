using System;
using System.Collections.Generic;

namespace SensorProcess
{
    public class Program
    {
        static void Main(string[] args)
        {
            SensorRead sensorRead = new SensorRead();
            PrintMethod printMethod = new PrintMethod();

            List<BMSParameterData> bmsParameterData = new List<BMSParameterData>();
            List<float> temperatureData = sensorRead.GenerateTemperatureData(1, 100);
            List<float> chargeRateData = sensorRead.GenerateChargeRateData(1, 50);

            for (int i=0;i<temperatureData.Count;i++)
            {
                BMSParameterData bmsParameter = new BMSParameterData();
                bmsParameter.Temperature = temperatureData[i];
                bmsParameter.ChargeRate = chargeRateData[i];

                bmsParameterData.Add(bmsParameter);
            }

            printMethod.PrintParameterValues(bmsParameterData);
        }
    }
}

using System;
using System.Collections.Generic;

namespace SensorProcess
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature (Sensor1) Data");
            SensorProcessMethods sensorProcess = new SensorProcessMethods();

            List<BMSParameterData> bmsParameterData = new List<BMSParameterData>();
            List<float> temperatureData = sensorProcess.GenerateTemperatureData(1, 100);
            List<float> chargeRateData = sensorProcess.GenerateChargeRateData(1, 50);

            for (int i=0;i<temperatureData.Count;i++)
            {
                BMSParameterData bmsParameter = new BMSParameterData();
                bmsParameter.Temperature = temperatureData[i];
                bmsParameter.ChargeRate = chargeRateData[i];

                bmsParameterData.Add(bmsParameter);
            }

            sensorProcess.PrintParameterValues(bmsParameterData);
        }
    }
}

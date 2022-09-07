using System;

namespace SensorProcess
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("Temperature (Sensor1) Data");
            SensorRead sensorRead = new SensorRead();
            sensorRead.ReadSensorData();

            Console.WriteLine("State Of Charge (SOC) (Sensor2) Data");
            sensorRead.ReadSensorData();
        }
    }
}

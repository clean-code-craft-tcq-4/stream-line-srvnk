using System;

namespace SensorProcess
{
    public class SensorRead
    {
        public void ReadSensorData()
        {
            Random randData = new Random();
            for (int i = 0; i < 50; i++)
            {
                float sensorData = randData.Next(0, 100);
                Console.WriteLine(sensorData);
            }
        }
    }
}

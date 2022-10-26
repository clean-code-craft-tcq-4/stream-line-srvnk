using System;
using System.Collections.Generic;

namespace SensorProcess
{
    public class PrintMethod
    {
        public void PrintParameterValues(List<BMSParameterData> bmsParameterData)
        {
            Console.WriteLine("Temerature\t\t\t ChargeRate Values\n");

            foreach(BMSParameterData bmsParameter in bmsParameterData)
            {
                Console.WriteLine(bmsParameter.Temperature + "\t\t\t" + bmsParameter.ChargeRate + "\n");
            }
        }
    }
}

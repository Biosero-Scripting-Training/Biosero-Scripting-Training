using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using BioSero.GreenButtonGo.Scripting;

namespace GreenButtonGo.Scripting
{
    public class ConvertF_to_C : BioSero.GreenButtonGo.GBGScript
    {

        public void Run(Dictionary<String, Object> variables, RuntimeInfo runtimeInfo)
        {
            // This script pulls in the variable TemperatureF and converts it to Celcius then places the result in TemperatureC
            double TempF = (double)variables["TemperatureF"];
            double TempC = (TempF - 32) / 1.8f;
            TempC = Math.Round(TempC, 2);
            variables["TemperatureC"] = TempC;
        }
    }
}
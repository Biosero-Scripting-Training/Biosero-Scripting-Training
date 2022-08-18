using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using BioSero.GreenButtonGo.Scripting;

namespace GreenButtonGo.Scripting
{
    public class ConvertC_to_F : BioSero.GreenButtonGo.GBGScript
    {

        public void Run(Dictionary<String, Object> variables, RuntimeInfo runtimeInfo)
        {
            // This script pulls in the variable TemperatureC and converts it to Fahrenheit then places the result in TemperatureF
            double TempC = (double)variables["TemperatureC"];
            double TempF = (TempC * 1.8)+32;
            TempF = Math.Round(TempF, 2);
            variables["TemperatureF"] = TempF;
        }
    }
}
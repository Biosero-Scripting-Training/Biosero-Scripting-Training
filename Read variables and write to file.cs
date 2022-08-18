using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using BioSero.GreenButtonGo.Scripting;
using System.Threading.Tasks;

namespace GreenButtonGo.Scripting
{
    public class Read_variables_and_write_to_file : BioSero.GreenButtonGo.GBGScript
    {

        public void Run(Dictionary<String, Object> variables, RuntimeInfo runtimeInfo)
        {
            string line = 
                variables["TODO: ENTER STRING 0 NAME HERE !!!"] as string + "," +
                variables["TODO: ENTER STRING 1 NAME HERE !!!"] as string + "," +
                variables["TODO: ENTER STRING 2 NAME HERE !!!"] as string;

            var filePath = @"TODO: ENTER PATH OF FILE HERE!!!";

            Task.Run(() => File.AppendAllText(filePath, line + Environment.NewLine));
        }
    }
}
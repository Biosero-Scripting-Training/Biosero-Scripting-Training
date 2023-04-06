using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using BioSero.GreenButtonGo.Scripting;

namespace GreenButtonGo.Scripting
{
    public class Script_1 : BioSero.GreenButtonGo.GBGScript
    {

        public void Run(Dictionary<String, Object> variables, RuntimeInfo runtimeInfo)
        {
            int batches = 9;
            string test = batches.ToString();
            runtimeInfo.Trace(test);
            runtimeInfo.Trace(string.Format("{0:00} batches", batches));
        }
    }
}

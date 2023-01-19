using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using BioSero.GreenButtonGo.Scripting;

namespace GreenButtonGo.Scripting
{
    public class ForLoop : BioSero.GreenButtonGo.GBGScript
    {

        public void Run(Dictionary<String, Object> variables, RuntimeInfo runtimeInfo)
        {
            // Insert code here:
            // Loop 5 times
            for (int i = 1; i <= 5; i++)
            {
                // Write the loop number to the trace
                string foo = String.Format("Loop number: {0}", i);
                runtimeInfo.Trace(foo);
            }
        }
    }
}

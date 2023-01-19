using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using BioSero.GreenButtonGo.Scripting;

namespace GreenButtonGo.Scripting
{
    public class FirstMethod : BioSero.GreenButtonGo.GBGScript
    {

        public void Run(Dictionary<String, Object> variables, RuntimeInfo runtimeInfo)
        {
            // Insert code here:
            // Loop 5 times  
        int i =0;
        while (i <5)
            {
                // Write the loop number to the trace
                string foo = String.Format("Loop number: {0}", i);
                i++;
               runtimeInfo.Trace(foo);    
            }
            Printer();
        }
        static void Printer()
        { 
        MessageBox.Show("Loops completed","All Done");
        }
    }
}

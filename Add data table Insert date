using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using BioSero.GreenButtonGo.Scripting;
using BioSero.GreenButtonGo;

namespace GreenButtonGo.Scripting
{
    public class Script_3 : BioSero.GreenButtonGo.GBGScript
    {

        public void Run(Dictionary<String, Object> variables, RuntimeInfo runtimeInfo)
        {
          var now = DateTime.Now; //Get current date
          string strNow = now.ToLongDateString(); //Make it a string
          Database.CreateOrClearTable("Data Table", new[] {"Date_Time", "Row2", "Row3"}); //Create the data table
          Database.Insert("Data_Table", new[] { "Date_Time", "Row2", "Row3" }, new[] {strNow, "A1", "Sample 1" }); //Put some data in there
        }
    }
}

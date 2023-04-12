using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using BioSero.GreenButtonGo.Scripting;

namespace GreenButtonGo.Scripting
{
    public class All_Plate_Reset_Has_Been_Run : BioSero.GreenButtonGo.GBGScript
    {

        public void Run(Dictionary<String, Object> variables, RuntimeInfo runtimeInfo)
        {
        // Make script somewhat universal
	   string dataTableName = "Put_DataTable_Here";
	// Reset all Plates in Hotel Storage to from "Has_Been_Run" False to True:
            string tableName = dataTableName;
            string whereColumnName = "Has_Been_Run";
            string whereColumnValue = "True";
            string [] headers = new string [] { "Has_Been_Run" };
            string [] values = new string [] { "False" };
            
            Database.UpdateRow(tableName, whereColumnName, whereColumnValue, headers, values);

        }
    }
}

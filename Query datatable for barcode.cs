using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using BioSero.GreenButtonGo.Scripting;

namespace GreenButtonGo.Scripting
{
    public class Query_datatable_for_barcode : BioSero.GreenButtonGo.GBGScript
    {

        public void Run(Dictionary<String, Object> variables, RuntimeInfo runtimeInfo)
        {
            // Insert code here:
            string sourceBarcode = "Plate 1"; //the barcode you are searching for
            string tableName = "Plate_Storage_Hotels";
            List<string[]> table = Database.GetAllRows(tableName, new string[] { "BARCODE", "HOTEL", "SHELF", "HAS_BEEN_RUN"}).ToList(); //Make sure you add the rows with the useful information. Barcode must be first otherwise adjust the index in the array below
            var matchingSources = table.Where(row=>row[0] == sourceBarcode).ToList();
            foreach (string[] row in matchingSources)
            {
                foreach (string s in row)
                {
                    runtimeInfo.Trace(s);
                }
            }
            int matches = matchingSources.Count;
            runtimeInfo.Trace(String.Format("{0:00} Matches found!!", matches));

        }
    }
}

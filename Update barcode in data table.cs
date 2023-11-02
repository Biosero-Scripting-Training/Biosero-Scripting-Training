using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using BioSero.GreenButtonGo.Scripting;

namespace GreenButtonGo.Scripting
{
    public class Update_barcode_in_data_table : BioSero.GreenButtonGo.GBGScript
    {

        public void Run(Dictionary<String, Object> variables, RuntimeInfo runtimeInfo)
        {
            // Insert code here:
            string oldBarcode = "Plate 1"; //look for this barcode
            string newBarcode = "Thing 1"; //replace it with this barcode

            // Name of table to be accessed
            string tableName = "Plate_Storage_Hotels"; //Look in this table
                 
            // Write to table
            Database.UpdateRow(tableName, "BARCODE", oldBarcode, "BARCODE", newBarcode); //Do the work of updating the barcode

        }
    }
}

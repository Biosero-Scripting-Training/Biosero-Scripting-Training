using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using BioSero.GreenButtonGo.Scripting;
using BioSero.GreenButtonGo;

namespace GreenButtonGo.Scripting
{
    public class Script_2 : BioSero.GreenButtonGo.GBGScript
    {

        public void Run(Dictionary<String, Object> variables, RuntimeInfo runtimeInfo)
        {
            // Fill zone 1 with plate 1 - 10
            var storage = GetInstrument("Plate Storage");
            storage.ClearHotels();
            storage.FillHotels("Zone 1", "Plate", 10);
            
            //run edit content
            storage.Run("Edit Content"); //This is optional
            //find barcode
            var value = storage.Run("Find In Hotel By Barcode Or Zone", "Plate1");
            MessageBox.Show(string.Join(",", value));
            return;

        }
    }
}

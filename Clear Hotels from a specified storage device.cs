using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using BioSero.GreenButtonGo.Scripting;

namespace GreenButtonGo.Scripting
{
    public class Clear_Carousel_Hotels : BioSero.GreenButtonGo.GBGScript
    {

        public void Run(Dictionary<String, Object> variables, RuntimeInfo runtimeInfo)
        {
           //Get the storage device name
		   var plateStorageName = GetInstrument ("Carousel");

            //Clear Hotel Storage
            plateStorageName.ClearHotels();

        }
    }
}
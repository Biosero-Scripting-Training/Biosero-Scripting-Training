using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using BioSero.GreenButtonGo.Scripting;
using System.Net;


namespace GreenButtonGo.Scripting
{
    public class Turn_Lights_Off : BioSero.GreenButtonGo.GBGScript
    {

        public void Run(Dictionary<String, Object> variables, RuntimeInfo runtimeInfo)
        {
            // Insert code here:
          var url = "http://address.com:8080/rest/items/Object"; //Base URL

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST"; //Rest Action or Verb

            httpRequest.Accept = "application/json"; //Content Declarations
            httpRequest.ContentType = "text/plain";

            var data = "OFF"; //Post Off to Object

        using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
        {
            streamWriter.Write(data);
        }

        var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        {
            var result = streamReader.ReadToEnd();
        }

        Console.WriteLine(httpResponse.StatusCode);

        }
    }
}
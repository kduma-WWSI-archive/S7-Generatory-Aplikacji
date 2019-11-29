using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace Generator
{
    public class Exporter
    {
        internal static void MakeExe(string sourceExe, string destinationExe, Konfiguracja conf)
        {
            if (File.Exists(destinationExe))
                File.Delete(destinationExe);
            
            File.Copy(sourceExe, destinationExe);

            using (var sw = File.AppendText(destinationExe))
            {
                for (var i = 0; i < 20; i++)
                    sw.Write("\n");

                sw.WriteLine("<<<<<<<<<<<<<<<<<<<<USERDATA>>>>>>>>>>>>>>>>>>>>");
                sw.Flush();



                var serializer = new DataContractSerializer(typeof(Konfiguracja));
                using (var writer = new XmlTextWriter(sw))
                {
                    writer.Formatting = Formatting.Indented; // indent the Xml so it's human readable
                    serializer.WriteObject(writer, conf);
                    writer.Flush();
                }
            }

        }
    }
}
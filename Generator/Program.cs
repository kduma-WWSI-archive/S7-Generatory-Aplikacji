using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Generator
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (StreamReader sr = File.OpenText("C:\\Users\\Krystian Duma\\Desktop\\test.exe"))
            //using (StreamReader sr = File.OpenText(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName))
            {
                string s = "";
                bool user_content = false;
                while ((s = sr.ReadLine()) != null)
                {
                    if (s == "<<<<<<<<<<<<<<<<<<<<USERDATA>>>>>>>>>>>>>>>>>>>>")
                        user_content = true;

                    if (user_content)
                        break;
                }

                if (user_content)
                {
                    Konfiguracja konfiguracja;
                    using (Stream stream = new MemoryStream())
                    {
                        byte[] data = System.Text.Encoding.UTF8.GetBytes(sr.ReadToEnd().Trim());
                        stream.Write(data, 0, data.Length);
                        stream.Position = 0;
                        DataContractSerializer deserializer = new DataContractSerializer(typeof(Konfiguracja));
                        konfiguracja = (Konfiguracja)deserializer.ReadObject(stream);

                    }


                    var sql = SqlGenerator.From(konfiguracja);

                    Application.Run(new Aplikacja(konfiguracja, sql));
                    return;
                }
                
            }
            
            
            Application.Run(new FormGenerator());
        }
    }
}

﻿using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace EdgeNote.UI.Objects
{
    public class AppConfiguration
    {
        private static AppConfiguration m_AppConfig;

        public static AppConfiguration GetInstance()
        {
            if (m_AppConfig == null)
            {
                var assembly = typeof(AppConfiguration).GetTypeInfo().Assembly;
                Stream stream = assembly.GetManifestResourceStream("EdgeNote.AppConfiguration.json");
                string json = "";
                using (var reader = new StreamReader(stream))
                {
                    json = reader.ReadToEnd();
                }

                m_AppConfig = JsonConvert.DeserializeObject<AppConfiguration>(json);
            }

            return m_AppConfig;
        }

        public string ApiUrl { get; set; }
        public string ApiAccessKey { get; set; }
        public string LogglyHost { get; set; }
        public string LogglyToken { get; set; }
        public string LogglyResource { get; set; }
    }
}

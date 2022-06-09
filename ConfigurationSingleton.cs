using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacTep_9lpJIblkoB_2
{
    class ConfigurationSingleton
    {
        private static ConfigurationSingleton configurationSingleton;
        private string appPath;
        private string _imagesDirectory;

        public string AppPath { get; private set; }
        public string ImagesDirectory { get; private set; }
        

        private ConfigurationSingleton()
        {
            AppPath = Environment.CurrentDirectory;
        }

        public static ConfigurationSingleton GetConfiguration()
        {
            if(configurationSingleton == null) configurationSingleton = new ConfigurationSingleton();  
            return configurationSingleton;
        }
    }
}

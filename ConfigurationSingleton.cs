using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacTep_9lpJIblkoB_2
{
    class ConfigurationSingleton
    {
        private static ConfigurationSingleton appConfiguration;

        public string AppPath { get; private set; }
        public string ImagesDirectory { get; private set; }
        
        public string BackgroundDirectory { get; private set; }
        
        public string LogsDirectory { get; private set; }

        public string ErrorsDirectory { get; private set; }

        private ConfigurationSingleton()
        {
            AppPath = Environment.CurrentDirectory;
            ImagesDirectory = CheckPath(AppPath + @"\Images");
            BackgroundDirectory = CheckPath(ImagesDirectory + @"\Backgrounds");
            LogsDirectory = CheckPath(AppPath + @"\Logs");
            ErrorsDirectory = CheckPath(LogsDirectory + @"\Errors");
        }

        public static ConfigurationSingleton GetConfiguration()
        {
            if(appConfiguration == null) appConfiguration = new ConfigurationSingleton();  
            return appConfiguration;
        }

        //проверка пути к папке, если отсутствует, значит создать папку
        private string CheckPath(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new Exception("путь имеет значение Null или пуст");
            }
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }
    }
}

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

        public string StartBackgroundImagePath { get; private set; }

        private ConfigurationSingleton()
        {
            AppPath = Environment.CurrentDirectory;
            ImagesDirectory = CheckPath(AppPath + @"\Images");
            BackgroundDirectory = CheckPath(ImagesDirectory + @"\Backgrounds");
            LogsDirectory = CheckPath(AppPath + @"\Logs");
            ErrorsDirectory = CheckPath(LogsDirectory + @"\Errors");
            StartBackgroundImagePath = BackgroundDirectory + @"\StartBackground.jpg";

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

    //[Serializable()]
    //public class proJect_configuration
    //{
    //    #region IP и порт
    //    public string IP1 { get; set; }
    //    public string IP2 { get; set; }
    //    public string IP3 { get; set; }
    //    public string IP4 { get; set; }
    //    public string full_IP { get; set; }
    //    public int Homep_nopTa { get; set; }
    //    #endregion

    //    #region путь к файлам и папкам
    //    private string Ha3BaHue_nanku_config = "configuration";
    //    private string Ha3BaHue_qpauJIa_config = "IDandPort";
    //    #endregion

    //    public proJect_configuration()
    //    {
    //        IP1 = "155";
    //        IP2 = "999";
    //        IP3 = "3";
    //        IP4 = "3";
    //        full_IP = IP1 + "." + IP2 + "." + IP3 + "." + IP4;
    //        Homep_nopTa = 1234;
    //    }

    //    public void cepuaJIu3oBaTb_B_qpauJI()
    //    {
    //        if (!Directory.Exists(Environment.CurrentDirectory + @"\" + Ha3BaHue_nanku_config)) Directory.CreateDirectory(Environment.CurrentDirectory + @"\" + Ha3BaHue_nanku_config);
    //        Stream stream = File.Open(Environment.CurrentDirectory + @"\" + Ha3BaHue_nanku_config + @"\" + Ha3BaHue_qpauJIa_config + ".bin", FileMode.Create);
    //        BinaryFormatter serialization = new BinaryFormatter();
    //        serialization.Serialize(stream, okHo_ucnpaBJIeHu9l_6paka.KoHqpurypacu9l_npoekTa);
    //        stream.Close();
    //    }

    //    public void cepuaJIu3oBaTb_u3_qpauJIa()
    //    {
    //        try
    //        {
    //            Stream stream = File.Open(Environment.CurrentDirectory + @"\" + Ha3BaHue_nanku_config + @"\" + Ha3BaHue_qpauJIa_config + ".bin", FileMode.Open);
    //            BinaryFormatter serialization = new BinaryFormatter();
    //            okHo_ucnpaBJIeHu9l_6paka.KoHqpurypacu9l_npoekTa = serialization.Deserialize(stream) as proJect_configuration;
    //            stream.Close();
    //        }
    //        catch { }
    //    }

    //    //public static void cepuaJIu3oBaTb_config()
    //    //{

    //    //}

    //}


}

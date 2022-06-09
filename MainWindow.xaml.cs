using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MacTep_9lpJIblkoB_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string[] _imagesBackgroundMass;
        private ConfigurationSingleton appConfig;
        public MainWindow()
        {
            InitializeComponent();
            appConfig = ConfigurationSingleton.GetConfiguration();
            _imagesBackgroundMass = ImageFinder.FindAllImages(appConfig.BackgroundDirectory);
        }

        private void buttonAppConfig_Click(object sender, RoutedEventArgs e)
        {
            ConfigWindow _configWindow = new ConfigWindow();
            _configWindow.Show();
        }
    }
}

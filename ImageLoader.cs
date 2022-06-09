using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MacTep_9lpJIblkoB_2
{
    class ImageLoader
    {
       // qpoH_npuJIoJeHu9l = new ImageBrush();
        //qpoH_npuJIoJeHu9l.ImageSource = new BitmapImage(new Uri(Environment.CurrentDirectory + @"\images\fon1.jpg"));
           // this.Background = qpoH_npuJIoJeHu9l;
        public void LoadBackgroundImage(string _imagePath, Control _control)
        {
            if (!string.IsNullOrEmpty(_imagePath)) {
                ImageBrush _image = new ImageBrush();
                _image.ImageSource = new BitmapImage(new System.Uri(_imagePath));
                _control.Background = _image;
            }
        }
    }
}

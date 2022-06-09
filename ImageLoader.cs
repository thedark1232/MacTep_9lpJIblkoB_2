using System;
using System.IO;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MacTep_9lpJIblkoB_2
{
    static class ImageLoader
    {
        /// <summary>
        /// заливает изображение в Background объекта Control (возвращает true при успехе, false при неудаче)
        /// </summary>
        /// <param name="_imagePath"></param>
        /// <param name="_control"></param>
        /// <returns></returns>
        public static bool LoadBackgroundImage(string _imagePath, Control _control)
        {
            if (string.IsNullOrEmpty(_imagePath)) return false;
            if (!File.Exists(_imagePath)) return false;

            try
            {
                ImageBrush _image = new ImageBrush();
                _image.ImageSource = new BitmapImage(new Uri(_imagePath));
                _control.Background = _image;
                return true;
            }
            catch
            {
                return false;
            }
           
        }
    }
}

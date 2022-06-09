using System;
using System.Collections.Generic;
using System.IO;


namespace MacTep_9lpJIblkoB_2
{
    static class ImageFinder
    {
        public static string[] FindAllImages(string _path)
        {

            if (string.IsNullOrEmpty(_path))
            {
                return new string[0];
            }
            if (!Directory.Exists(_path))
            {
                return new string[0];
            }
            string[] _imagesArray = Directory.GetFiles(_path, "*.jpg", SearchOption.TopDirectoryOnly);
            return _imagesArray;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;


namespace MacTep_9lpJIblkoB_2
{
    class ImageFinder
    {
        public string[] FindAllImages(string _path)
        {
            if (string.IsNullOrEmpty(_path))
            {
                throw new Exception("путь для поиска изображений не задан");
            }
            if (!Directory.Exists(_path))
            {
                throw new Exception("путь не существует");
            }
            string[] _imagesArray = Directory.GetFiles(_path, "*.jpg", SearchOption.TopDirectoryOnly);
            return _imagesArray;

        }
    }
}

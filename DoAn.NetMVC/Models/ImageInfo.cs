using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace DoAn.NetMVC.Models
{
    public class ImageInfo
    {
        private readonly Image image;
        private readonly FileInfo fileInfo;

        public ImageInfo(string path)
        {
            image = Image.FromFile(path);
            fileInfo = new FileInfo(path);
        }

        public string GetDimensions() => $"{image.Width}x{image.Height}";
        public int Width() => image.Width;
        public int Heigth() => image.Height;

        public string Size()
        {
            double size = fileInfo.Length;
            if (size < 1024)
            {
                return $"{size} bytes";
            }
            return size < 1048576 ? $"{Math.Round(size / 1024, 2)} KB" : $"{Math.Round(size / 1048576, 2)} MB";
        }
    }
}
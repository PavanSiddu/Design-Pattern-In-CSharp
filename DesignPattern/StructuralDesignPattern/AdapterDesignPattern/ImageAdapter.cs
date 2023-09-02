using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    public class ImageAdapter : IImageViewer
    {
        IAdvancedImageViewer advancedImageViewer;

        public ImageAdapter(string imageFormat)
        {

            if (string.Equals(imageFormat, "png", StringComparison.OrdinalIgnoreCase))
            {
                advancedImageViewer = new PngShower();
            }
            else if (string.Equals(imageFormat, "jpg", StringComparison.OrdinalIgnoreCase))
            {
                advancedImageViewer = new JpgShower();
            }
        }
        public void Show(string imageFormat, string fileName)
        {

            if (string.Equals(imageFormat, "png", StringComparison.OrdinalIgnoreCase))
            {
                advancedImageViewer.ShowPng(fileName);
            }
            else if (string.Equals(imageFormat, "jpg", StringComparison.OrdinalIgnoreCase))
            {
                advancedImageViewer.ShowJpg(fileName);
            }
        }
    }
}

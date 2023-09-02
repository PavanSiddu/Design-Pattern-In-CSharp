using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    public class GalleryApp : IImageViewer
    {
        ImageAdapter imageAdapter;
        public void Show(String imageFormat, String fileName)
        {

            //inbuilt support to show jpeg image files
            if (string.Equals(imageFormat, "jpeg", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Showing jpeg file. Name: " + fileName);
            }
            //imageAdapter is providing support to show other file formats
            else if (string.Equals(imageFormat, "png", StringComparison.OrdinalIgnoreCase) || string.Equals(imageFormat, "jpg", StringComparison.OrdinalIgnoreCase))
            {
                imageAdapter = new ImageAdapter(imageFormat);
                imageAdapter.Show(imageFormat, fileName);
            }
            else
            {
                Console.WriteLine("Invalid image. " + imageFormat + " format not supported");
            }
        }
    }
}

using System;

namespace DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    public class PngShower : IAdvancedImageViewer
    {
        public void ShowPng(string fileName)
        {
            Console.WriteLine("Showing png file. Name: " + fileName);
        }

        public void ShowJpg(string fileName)
        {
            //do nothing
        }
    }
}

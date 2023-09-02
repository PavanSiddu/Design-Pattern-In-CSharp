using System;

namespace DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    internal class JpgShower : IAdvancedImageViewer
    {
        public void ShowPng(string fileName)
        {
            //do nothing
        }

        public void ShowJpg(string fileName)
        {
            Console.WriteLine("Showing jpg file. Name: " + fileName);
        }
    }
}

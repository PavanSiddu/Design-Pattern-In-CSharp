using System;

namespace DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    public interface IAdvancedImageViewer
    {
        void ShowPng(string fileName);
        void ShowJpg(string fileName);
    }
}

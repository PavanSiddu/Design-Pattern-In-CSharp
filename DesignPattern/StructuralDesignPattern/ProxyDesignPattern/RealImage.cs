using System;

namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern
{
    // RealImage - Concrete class that provides actual functionality
    public class RealImage : IImage
    {
        // Instance variables - To store image-related data
        private double[] location = new double[2];
        private String name;
        private bool border;

        // Constructor - Used for object initializations
        public RealImage(String filename)
        {
            // Loads image from disk
            Console.WriteLine("Loaded from disk : " + filename);
            name = filename;
        }

        // Image Border Information
        public void SetBorder(bool border)
        {
            // sets the image border value
            this.border = border;
        }
        public bool GetBorder()
        {
            // returns the image border value
            return this.border;
        }

        // Image Location Information
        public void SetLocation(double x, double y)
        {
            // sets the image location
            this.location[0] = x;
            this.location[1] = y;
        }

        public double[] GetLocation()
        {
            // returns the image location
            return this.location;
        }

        // Image Display Functionality
        public void Display()
        {
            // Display the Image
            Console.WriteLine("Displayed : " + this.name);
        }
    }
}

namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern
{
    // Proxy - Virtual Proxy class
    public class Proxy : IImage
    {
        // Reference to the RealImage object.
        private RealImage image;

        // Instance variables
        private double[] location = new double[2];
        private string name;
        private bool border;

        // Constructor
        public Proxy(string filename)
        {
            // Instead of Loading the file, just cache the content.
            this.name = filename;
        }

        public void SetBorder(bool border)
        {
            if (image != null)
            {
                image.SetBorder(border);
            }
            else
            {
                this.border = border;
            }
        }

        public bool GetBorder()
        {
            if (image != null)
            {
                return image.GetBorder();
            }
            return this.border;
        }

        public void SetLocation(double x, double y)
        {
            if (image != null)
            {
                image.SetLocation(x, y);
            }
            else
            {
                this.location[0] = x;
                this.location[1] = y;
            }
        }

        public double[] GetLocation()
        {
            if (image != null)
            {
                return image.GetLocation();
            }
            return this.location;
        }

        public void Display()
        {
            // Create a RealImage object if it doesn't exist.
            if (image == null)
            {
                image = new RealImage(name);
                if (border)
                {
                    image.SetBorder(border);
                }
                if (location != null)
                {
                    image.SetLocation(location[0], location[1]);
                }
            }
            // Call the Display Functionality.
            image.Display();
        }
    }
}

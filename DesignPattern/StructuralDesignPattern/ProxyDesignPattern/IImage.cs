namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern
{
    // Image Interface - Defines the operations used by the Client
    public interface IImage
    {
        // Image Border Functionality
        bool GetBorder();
        void SetBorder(bool border);

        // Image Location Functionality
        double[] GetLocation();
        void SetLocation(double x, double y);

        // Image Display Functionality
        void Display();
    }
}
